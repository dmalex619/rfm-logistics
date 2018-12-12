<!DOCTYPE html>

<html xmlns='http://www.w3.org/1999/xhtml' style='height:100%;width:100%'>

<head>
    <title>Логистика на Яндекс.Карты</title>
    <meta http-equiv='Content-Type' content='text/html; charset=utf-8' />

    <!-- 
	    Загрузка основного API 
	    Язык - русский
	    Порядок следования координат: долгота, широта
    -->
    <script src='http://api-maps.yandex.ru/2.1/?load=package.standard&lang=ru-RU&coordorder=longlat' type='text/javascript'></script>
    
    <script type='text/javascript'>
	
	// ****************************************
	// Сюда вставляем динамические данные
    
    // Координаты центра карты
	var mapCenterCoords = <<<MapCenterCoords>>>;
	// Пример - [37.620363, 55.755847] - центр Москвы
    
    // Координаты базы
	var baseCoords = <<<BaseCoords>>>;
    // Пример - [38.115555, 55.555333] - Наркомвод
    
    // Режим работы: 'P' - режим ShowPartner, 'T' - режим ShowTrip
    var workMode = <<<WorkMode>>>;
    // Пример - 'T'
    
    // Данные для режима ShowPartner
	var onePartnerCoords = <<<OnePartnerCoords>>>;
    // Пример - [37.809875, 55.696448]
	var onePartnerAddress = <<<OnePartnerAddress>>>;
	// Пример - 'Москва, Волгоградский пр-т, дом № 18'
	var onePartnerName = <<<OnePartnerName>>>;
	// Пример - 'АБК Ритейл';
    
    // Данные для режима ShowTrip
    var tripCoords = <<<TripCoords>>>;
    // Пример - [[37.809875, 55.696448], [37.727922, 55.611693], [37.738692, 55.763964]];
    var tripPartners = <<<TripPartners>>>;
    // Пример - ['АБК Ритейл', 'Абдулаев ИП', 'Радзивидло ПБОЮЛ'];
    var tripAddresses = <<<TripAddresses>>>;
    // Пример - ['Москва, Волгоградский пр-т, 18', 'Москва, Ореховый б-р, 24', 'Москва, Соколиной Горы 5-я ул, 16'];
    var tripIcons = <<<TripIcons>>>;
    // Пример - ['islands#blueDotIcon', 'islands#darkGreenDotIcon', 'islands#redDotIcon'];
    var tripCars = <<<TripCars>>>;
    // Пример - ['509 Мицубиси', '181 Портер', '429 Скания'];
    
	// Конец динамической вставки
	// ****************************************
    
    
    
    // Переменные для будущего использования
    var map;
	var basePoint, onePartnerPoint; 
	var tripArray;
	
    
    
    // Начало работы
    // Дождёмся загрузки API и готовности DOM
    ymaps.ready(init);
    
    function init () {
        // При создании карты определяем 2 необходимых параметра (центр и масштаб),
        // а также несколько дополнительных (тип карты, элементы управления, набор поведений)
        map = new ymaps.Map(document.getElementById('YMapsID'), {
            center: mapCenterCoords, 
            zoom: 10, 
            type: 'yandex#map', 
            controls: ['rulerControl', 'typeSelector', 'zoomControl'] , 
            behaviors: ['drag', 'scrollZoom' ]
            } );
        
        // Точка с координатами базы
	    basePoint = new ymaps.Placemark( baseCoords ,
		    { hintContent: '<b>База</b>' }, 
		    { preset: 'islands#brownDotIcon', draggable: false}
	    );
	    map.geoObjects.add(basePoint);
        
        
        
        // Кнопка печати
        var btnPrint = new ymaps.control.Button( {
		    data: { content: 'Печать', title: 'Печать карты' }, 
		    options: { float: 'left', floatIndex: 9, selectOnClick: false }
	    });
        btnPrint.events.add( 'press', function () {
		    window.print(); 
        });
        map.controls.add(btnPrint);	
        
        
        
        // Кнопка "Пробег до клиента" / "Расчет маршрута"
        // Событие <press> определяется ниже, в зависимости от режима работы
        if (workMode == 'P') { var btnContent = 'Пробег', btnTitle = 'Расчет пробега до клиента'; }
        else { var btnContent = 'Маршрут', btnTitle = 'Расчет и отображение маршрута'; }
        var btnCalc = new ymaps.control.Button( {
	        data: { content: btnContent, title: btnTitle }, 
	        options: { float: 'left', floatIndex: 1, selectOnClick: false }
            });
        // Добавление кнопки на карту
        map.controls.add(btnCalc);
        
        // Освобождение памяти
        btnContent = btnTitle = null;

        
	    // Режим ShowPartner (точка с координатами одного партнера)
	    // Так как запрос координат выполняется асинхронно (т.е. непонятно когда), сам процесс добавления метки пришлось перенести в callback-функцию
	    // Объяснение смотри здесь: http://javascript.ru/forum/misc/30194-javascript-then.html и http://habrahabr.ru/post/127482/
	    if (workMode == 'P') {
		    // Координаты существуют?
		    if (onePartnerCoords.length > 0) { 
		        setOnePartnerPoint( onePartnerCoords, 'C'); 
		    }
		    // Адрес существует?
		    else if (onePartnerAddress.length > 0) {
			    ymaps.geocode(onePartnerAddress, { results : 1 } )
			        .then( function (res) {
			            // Если геокодирование не вернуло результатов - ставим метку в центр карты
			            var coords = res.geoObjects.get(0).geometry.getCoordinates();
			            if (coords.length == 0) coords = mapCenterCoords;
				        setOnePartnerPoint( coords, 'A');
		            } );
		    }
		    // Нет ни координат, ни адреса - ставим точку по центру карты
		    else { 
		        setOnePartnerPoint( mapCenterCoords, 'U'); 
		    }
            
            // Callback-функция для отрисовки метки одного партнера
		    function setOnePartnerPoint (coords, mode) {
		        // Определение вида метки в зависимости от режима
		        // Список стандартных меток для версии API 2.1 смотри здесь: http://api.yandex.ru/maps/doc/jsapi/2.1/ref/reference/option.presetStorage.xml
		        var icon;
		        if (mode == 'C') icon = 'islands#nightDotIcon';     //'islands#darkBlueStretchyIcon'
		        else icon = 'islands#redDotIcon';      // 'islands#redStretchyIcon'
		        
		        // Создание метки, определение общих свойств и опций
    		    onePartnerPoint = new ymaps.GeoObject( { geometry: { type: 'Point', coordinates: coords } } );
	    	    //onePartnerPoint.properties.set( { iconContent: onePartnerName, hintContent: onePartnerAddress } );
	    	    onePartnerPoint.properties.set( { hintContent: '<b>' + onePartnerName + '</b><br>' + onePartnerAddress } );
		        onePartnerPoint.options.set( { draggable: true, preset: icon } );
    		    
    		    // Освобождение памяти
    		    icon = null;
    		    
		        // Добавление обработчика события перетаскивания метки
		        onePartnerPoint.events.add('dragend', function (e) {
		            if (window.external) { 
		                // Возврат новых координат
		                window.external.PartnerGetCoordinates(onePartnerPoint.geometry.getCoordinates()); 
		            }
		        });
    	        
	            // Добавление метки на карту
		        map.geoObjects.add(onePartnerPoint);
    		    
		        // Центрирование и зуммирование карты
		        map.setCenter(coords);
		        map.setZoom(15);
		    }
	        
	        // Обработчик нажатия кнопки
            btnCalc.events.add( 'press', function () {
                if (onePartnerPoint.geometry.getCoordinates().length > 0) {
                    // Удаление старого маршрута (если имеется)
                    // Оставляем в массиве геообъектов только 2 элемента (базу и партнера)
                    while (map.geoObjects.getLength() > 2) {
                        lastObject = map.geoObjects.get(map.geoObjects.getLength() - 1);
                        map.geoObjects.remove(lastObject);
                    }
                    
                    // Расчет пробега до клиента
	    	        ymaps.route([ basePoint.geometry.getCoordinates(), onePartnerPoint.geometry.getCoordinates() ], { 
	    	                // Установка режима автоматической подгонки карты для отображения всего маршрута
	    	                mapStateAutoApply: true, zoomMargin: 3 
	    	            } ).then(function (route) {
                            // Установки невидимости точек маршрута (чтобы сохранить видимыми метки базы и партнера)
                            route.getWayPoints().options.set('visible', false);
                            
                            // Расчет нового центра карты
                            // ОБЯЗАТЕЛЬНО вызвать ДО добавления маршрута на карту, иначе не масштабируется!!!
                            rLng = (basePoint.geometry.getCoordinates()[0] + onePartnerPoint.geometry.getCoordinates()[0]) / 2;
                            rLat = (basePoint.geometry.getCoordinates()[1] + onePartnerPoint.geometry.getCoordinates()[1]) / 2;
                            map.setCenter( [ rLng, rLat] );
                            
                            // Добавление маршрута на карту
	    	                map.geoObjects.add(route);
    	    	            
	    	                // Отображение длины маршрута
	    	                // Функция getHumanLength() вне браузера выдает нечитаемый результат, поэтому вычисляем сами
	    	                // Balloon тоже не работает, применяем Hint
	    	                var rl = new Number(route.getLength() / 1000).toFixed(1);
	    	                map.hint.open( map.getCenter() , '<b>Пробег: ' + rl + ' км</b>');
	    	                //map.balloon.open( map.getCenter() , 'Пробег: ' + rl);
	    	                //map.balloon.open( map.getCenter() , 'Пробег: ' + route.getHumanLength());
	    	                
	    	                // Обнуление памяти
	    	                rl = null;
    	    	            
	    	                // Возврат дистанции до клиента
	    	                if (window.external) { 
	    	                    window.external.PartnerGetDistance(route.getLength().toFixed(0)); 
	    	                    }
	    	                },
	    	                // Обработка ошибки построения маршрута
	    	                function (err) { 
	    	                    alert('Невозможно построить маршрут!');
	    	            }
	    	        );
	    	    }
            });
	    }
        


	    // Режим ShowTrip (один маршрут)
        if (workMode == 'T') {
            // Min & max координаты для центрирования карты
            var minLng = 0, minLat = 0, maxLng = 0, maxLat = 0;
            
            // Создание массива объектов для будущего построения маршрута
            // Начальная точка маршрута - база
            tripArray = new Array(baseCoords);
            
            // Отрисовка всех точек маршрута
            for (var i = 0; i < tripCoords.length; i++) {
		        // Создание метки, определение общих свойств и опций
    		    newPoint = new ymaps.GeoObject( { geometry: { type: 'Point', coordinates: tripCoords[i] } } );
	    	    //newPoint.properties.set( { iconContent: tripPartners[i], hintContent: tripAddresses[i] } );
	    	    newPoint.properties.set( { hintContent: '<b>' + tripPartners[i] + '</b><br>' + tripAddresses[i] + '<br><i>' + tripCars[i] + '</i>' } );
		        newPoint.options.set( { draggable: false , preset: tripIcons[i] } );
        		
	            // Добавление метки на карту
		        map.geoObjects.add(newPoint);
		        
        		// Добавление точки в массив
        		tripArray[tripArray.length] = tripCoords[i];
        		
		        // Пересчет координат
		        if (minLng == 0 || minLng > tripCoords[i][0]) minLng = tripCoords[i][0];
		        if (maxLng == 0 || maxLng < tripCoords[i][0]) maxLng = tripCoords[i][0];
		        if (minLat == 0 || minLat > tripCoords[i][1]) minLat = tripCoords[i][1];
		        if (maxLat == 0 || maxLat < tripCoords[i][1]) maxLat = tripCoords[i][1];
            }
            
            // Конечная точка маршрута - база
            tripArray[tripArray.length] = baseCoords;
            
            // Центрирование и масштабирование карты
            map.setBounds([[minLng, minLat], [maxLng, maxLat]]).then(map.setZoom(map.getZoom() - 1));
            
	        // Обработчик нажатия кнопки
            btnCalc.events.add( 'press', function () {
                    // Расчет маршрута
	    	        ymaps.route( tripArray, { 
	    	                // Установка режима автоматической подгонки карты для отображения всего маршрута
	    	                mapStateAutoApply: true, zoomMargin: 3 
	    	            } ).then(function (route) {
                            // Установки невидимости точек маршрута (чтобы сохранить видимыми метки базы и всех партнеров)
                            route.getWayPoints().options.set('visible', false);
                            
                            // Добавление маршрута на карту
	    	                map.geoObjects.add(route);
    	    	            
	    	                // Отображение длины маршрута
	    	                // Функции getHumanLength() и getHumanTime вне браузера выдают нечитаемый результат, поэтому вычисляем сами
	    	                // Balloon тоже не работает, применяем Hint
	    	                var rl = new Number(route.getLength() / 1000).toFixed(1);
	    	                
	    	                var rt = new Number(route.getTime());
	    	                var rth = Math.floor(rt / 3600);
	    	                var rtm = Math.floor((rt - rth * 3600) / 60);
	    	                var rts = '';
	    	                if (rth > 0) rts = rth.toString() + ' ч ';
	    	                rts = rts + rtm.toString() + ' м';
	    	                
	    	                map.hint.open( map.getCenter() , '<b>Длина маршрута: ' + rl + ' км</b><br>Время движения: ' + rts);
	    	                /*map.balloon.open( map.getCenter() , 
	    	                    'Длина маршрута: ' + route.getLength() + '<br>Время движения: ' + route.getTime());
	    	                map.balloon.open( map.getCenter() , 
	    	                    'Длина маршрута: ' + route.getHumanLength() + '<br>Время движения: ' + route.getHumanTime());*/
    	    	            
    	    	            // Обнуление памяти
    	    	            tripArray = null;
    	    	            minLng = minLat = maxLng = maxLat = null;
    	    	            rl = rt = rth = rtm = rts = null;
    	    	            
	    	                },
	    	                // Обработка ошибки построения маршрута
	    	                function (err) { 
	    	                    alert('Невозможно построить маршрут!');
	    	            }
	    	        );
            });
        }
    }
    
    // Очистка карты при закрытии окна
    window.onunload = function(){ map.destroy(); }
    
    </script>
</head>

<body style='height:100%;width:100%;margin:0;padding:0'>
    <div id='YMapsID' style='width:100%;height:100%'></div>
</body>

</html>
