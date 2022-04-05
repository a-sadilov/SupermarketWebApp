<br />
<p align="center">
<img src="ManagmentApp.png" alt="Logo" width="400" height="100">

  <h3 align="center">Веб-менеджер супермаркета</h3>

  <p align="center">
    Это проект, помогающий менеджеру какого-либо магазина управлять его асортиментом онлайн.
    <br />
    <a href="https://fatclient.herokuapp.com/"><strong>Посмотреть демо »</strong></a>
    <br />
    <br />
    <a href="https://t.me/bisnachauszuvorbei">Телеграм автора</a>
    ·
    <a href="https://github.com/pavelqq/fatAPI">API проекта</a>
    ·
    <a href="https://github.com/pavelqq/fat/branches">История коммитов</a>
  </p>
</p>

<details open="open">
  <summary>Оглавление</summary>
  <ol>
    <li>
      <a href="#О проекте">О проекте</a>
      <ul>
        <li><a href="#Технологии">Технологии</a></li>
      </ul>
    </li>
    <li><a href="#Демонстрация работы">Благодарность</a></li>
    <li><a href="#Контакты">Контакты</a></li>
  </ol>
</details>

## О проекте

___
Концепция проекта заключается в создании CRUD приложения, для различных категорий товаров, и непосредственно для ведения отчетности продаж соответсвующих товаров
каждым из кассиров торговой сети.

Менеждер магазина может управлять категориями и непосредственно товарами (ценой, колличеством доступным для продажи, категорией товара). На вкладке "Транзакции" пользователь
может увидеть и распечатать отчет по продажам всех товаров для интересуемого периода времени, отфильтровав данные по ФИО кассира.
___

### Технологии

Здесь перечисленны технологии, которые использованы для создания
клиентского приложения:

* [C#]() - Поскольку я неплохо знаю C#, стал писать на нём 
* [HTML]() - based при использовании Razor Pages
* [Blazor]() - для интеграции C# в html
* [ASP.NET Core]() - кроссплатформенная среда для создания современных веб-приложений (и не только) на С#, подключенных к Интернету.
* [EF Core]() - ORM, в данном случае для создания базы данных на основе модели с помощью миграций.
* [MSSQL]() - СУБД

В принципе в **package.json** есть много других библиотек, но это либо эксперименты не вошедшие в релиз, либо заготовки на
будущее.


## Демонстрация работы

<video controls>
<source src="video/demo.mp4" type="video/mp4">
</video>

<a href="video/demo.mp4" style="display: block; width: 500px; height: 300px;" id="player"></a>
<script type="text/javascript">
flowplayer("player", "https://github.com/a-sadilov/SupermarketWebApp/Папка_с_плеером/файл_плеера.swf");
</script>


## Контакты

Email - [a.sadilov.official@gmail.com](mailto:a.sadilov.official@gmail.com)
Telegram - [@bisnachauszuvorbei](https://t.me/bisnachauszuvorbei)
