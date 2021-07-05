# Описание проекта
Тестовое задание для Xsolla Summer School 2021 по направлению Backend 

# Реализация 
* Проект выполнен на я/п C# и ASP.NET Core
* Решение имеет архитектуру шаблона "Хранилище", где контроллеры взаимодействуют с базой данных не напрямую, а через класс ProductOperations, в котором заранее были реализованы все методы интерфейса Iproduct. 
* База данных создана при помощи технологии Entity Framework

# Описание api
Структура запроса "https://localhost:{PORT}/api/Product/{OPERATION}"
Были реализованы следующие запросы : 
1) api/Product/Get - Возвращает все записи из базы данных
2) api/Product/Get/{Id} - Возвращает указанную по Id запись из базы данных
3) api/Product/Get/ByPrice - Возвращает отсортированный по цене список записей из базы данных
4) api/Product/Get/ByType - Возвращает отсортированный по типу список записей из базы данных
5) api/Product/Create - Добавляет новую запись в базу данных 
6) api/Product/Update/{Id} - Изменяет данные указанной по Id записи в базе данных
7) api/Product/Delete/{Id} - Удаляет указанную по Id запись из базы данных 

# Запуск решения
Перед запуском решения требуется загрузить 5 Nuget пакетов :
1) Microsoft.EntityFrameworkCore
2) Microsoft.EntityFrameworkCore.SqlServer
3) Microsoft.EntityFrameworkCore.Tools
4) Swashbuckle.AspNetCore
5) Swashbuckle.AspNetCore.Swagger
