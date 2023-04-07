# Practic Perepelkin 2 <img src="https://pixelbox.ru/wp-content/uploads/2021/10/gif-for-steam-pixelbox.ru-16.gif" height="50"/></h1>   
[![Typing SVG](https://readme-typing-svg.herokuapp.com?color=%2336BCF7&lines=My+second+practice+work)](https://i.gifer.com/BulL.gif)
###### Day 2 ######
-------------------------
<a href="Practic_ApiDB_2/Practic_Api_1/Models/WebShopContext.cs">Connect a SQL DB to the API</a>     
<a href="Practic_ApiDB_2/Practic_Api_1/Models">All models in the app</a>     
## Тематика: интернет-магазин. ##  
### Для начала необходимо грамотно спроектировать базу данных.
![image](https://user-images.githubusercontent.com/121193436/219652372-db464b9f-6010-4ac4-b2f5-9599370776a6.png)     
### После построения ER-модели переносим диограмму в SQL 
![image](https://user-images.githubusercontent.com/121193436/219659215-33e6d45e-1d22-4a65-bc39-0779a7070e4b.png)
<br></br>
### Следующий шаг, который предстоит сделать - миграция данных.    
Другими словами подключение бд к приложенияю и работа с ним.
![IMAGE 2023-02-18 22:03:26](https://user-images.githubusercontent.com/121193436/219883581-27178a7c-3c1d-41ce-8420-c5fa6aa3d549.jpg)

<br></br>
### Продолжение работы с API
<a href="Practic_ApiDB_3/Practic_Api_1/Controllers/UserController.cs">Основные функции API</a>    
<br></br>
#### Вывод всех данных из базы данных
![image](https://user-images.githubusercontent.com/121193436/224316716-054ab8b3-f10a-44a6-a15b-8574ed8fb944.png)    
<br></br>
#### Вывод данных по UserId
![image](https://user-images.githubusercontent.com/121193436/224316780-ecbfbd88-d2e0-41a8-b8ab-6aa959391ef7.png)
<br></br>
## Изменение файлов проекта
#### <a href="https://github.com/MaxZond/Practic-Day-2/tree/main/WebShop-Api">Просмотреть работу</a>
### Перемещаем некоторые интерфейсы и модели из DataAcsess и BusinessLogic в проект Domain.
![IMAGE 2023-03-24 02:48:00](https://user-images.githubusercontent.com/121193436/227388865-a19970db-d0ea-4758-b912-7951e69be39a.jpg)
<br></br>
### Задаем зависимость другим проектам
![IMAGE 2023-03-24 02:51:18](https://user-images.githubusercontent.com/121193436/227389163-b71b6c77-7545-4458-955d-b94675c2fc5d.jpg)
<br></br>
### Переход на асинхронность
#### Перейдем в класс RepositoryWrapper и измените метод Save()
![IMAGE 2023-03-24 02:53:21](https://user-images.githubusercontent.com/121193436/227389458-d44acd60-de26-484e-9bc4-fafcae30cbf7.jpg)
<br></br>
#### Адаптируем класс UserService под текущие изменения, например
![IMAGE 2023-03-24 02:55:56](https://user-images.githubusercontent.com/121193436/227389805-3868d182-c315-4b67-8526-f72151e327de.jpg)
<br></br>
### Изменим интерфейсы
#### Интерфейс IRepositoryBase
![IMAGE 2023-03-24 02:56:03](https://user-images.githubusercontent.com/121193436/227389989-a8f4828f-bc31-4642-91db-09e3a3e87658.jpg)      
#### Интерфейс IRepositoryWrapper
![IMAGE 2023-03-24 02:56:05](https://user-images.githubusercontent.com/121193436/227390130-e9c7381c-6d98-4155-952b-b6a4cddf94f8.jpg)      
#### Интерфейс IUserService
![IMAGE 2023-03-24 02:56:09](https://user-images.githubusercontent.com/121193436/227390180-a9b5c335-552e-4f84-909e-927b04984139.jpg)       

<br></br>
## Работа с Миграциями в EF Core
### Добавляем библиотеку Microsoft.EntityFrameworkCore.Tools в проект API
![IMAGE 2023-03-24 02:56:11](https://user-images.githubusercontent.com/121193436/227390303-dc02bb8e-5b74-4a07-a8e6-db8a222c84a0.jpg)
### Сформировались файлы для миграции в папке Migration
![image](https://user-images.githubusercontent.com/121193436/229068196-7a14bf6a-5570-4359-8db2-f94095c5172e.png)
### Для проверки работы, сформируем новую бд при помощи миграций. Изменяем имя в строке подключения на любое другое      
![image](https://user-images.githubusercontent.com/121193436/229068717-294a6593-831c-413e-bc23-6d4c7afb0496.png)
### Проверяем, что база данных сформировалась со всеми вашими таблицами
![image](https://user-images.githubusercontent.com/121193436/229073205-b79d424a-0409-49f4-96c2-6e0745e331f1.png)

<br></br>
## Работа с файлом .editorconfig    
#### Добовляем файл .editorconfig для всего проекта
![image](https://user-images.githubusercontent.com/121193436/230589133-76c0ec87-5258-4d13-a6db-046176ead9e2.png)
### Знакомимся с dotnet-cli    
#### Посмотрим в командной строке действия dotnet
![image](https://user-images.githubusercontent.com/121193436/230591983-a28c2db8-de64-4865-93d5-82a0c43e30e8.png)
#### Создадим новый консольный проект
![image](https://user-images.githubusercontent.com/121193436/230592663-6839dadb-896d-4656-84bb-c499346c69b1.png)
<br></br>
<a href="https://github.com/MaxZond/Practic-Day-2/blob/main/.github/workflows/dotnet-desktop.yml">Увидет .yml файл</a>

<br></br>
### Также был разработан ToDo лист для данной предметной области     
![image](https://user-images.githubusercontent.com/121193436/222652775-7a8ebfcc-74a7-45e3-9062-6c94e4f2048d.png) 
<a href="https://github.com/users/MaxZond/projects/4/views/1">Посмотреть</a>









<p align="center">
<img src="https://c.tenor.com/47jKSgBB3bEAAAAC/wave-donald-trump.gif" height="150"/></h1>   
</p>
