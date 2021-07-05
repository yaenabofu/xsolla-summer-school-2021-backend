# Описание проекта
Тестовое задание для Xsolla Summer School 2021 по направлению Backend 

# Реализация 
* Проект выполнен на я/п C# и ASP.NET Core
* Решение имеет архитектуру шаблона "Хранилище", где контроллеры взаимодействуют с базой данных не напрямую, а через класс-репозиторий ProductOperations, в котором заранее были реализованы все методы интерфейса IProduct. 
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
I Перед запуском решения убедитесь, что у вас установлены :
1) .NET Core версии 3.1
2) SQL Server
Nuget пакеты :
3) Microsoft.EntityFrameworkCore
4) Microsoft.EntityFrameworkCore.SqlServer
5) Microsoft.EntityFrameworkCore.Tools
6) Swashbuckle.AspNetCore
7) Swashbuckle.AspNetCore.Swagger

II Запустите консоль диспетчера Nuget пакетов (Средства -> Диспетчер пакетов Nuget) и выполните следующие команды:
1) Add-Migration Initial
2) Update-Database
