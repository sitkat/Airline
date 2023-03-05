# Airline

## Введение

AMONIC Airlines имеет офисы в разных странах, где активно осуществляются полеты. 
Информационная система, которая является предметом данного проекта, будет доступна 
менеджерам и операторам системы в этих офисах. Первой формой входа в систему будет форма 
авторизации. Следующие базовые характеристики решения должны быть выполнены в этой сессии:

• Предоставить доступ к различным разделам системы в зависимости от роли пользователя.

• Контроль и отслеживание доступа клиентов в систему.

Описание проекта и задание

В ходе разработки проекта убедитесь, что результаты соответствуют базовым требованиям, 
разработанным различными отделами AMONIC Airlines:

• Руководство по стилю должно быть применено однородно в ходе всей разработки

• Все требуемые модули ПО должны иметь применимые и полезные проверки и сообщения об 
ошибках, как запрашивает компания

• Где применимо используйте комментарии в коде, для дальнейшего более удобного чтения 
дальнейшими разработчиками системы

• Используйте соглашение об именовании для всех материалов, которые вам будут 
предоставляться

• Любая форма или отчет после создания, должен отражаться в центре экрана

• Когда форма или диалог активны, операции в других формах должны быть недоступны

• Кнопки Delete и Cancel должны быть красного цвета для избегания случайных нажатий

• При использовании цвета для строк или записей должно быть понятно, что эти цвета 
означают

• Каркасы форм, приведенные в этом документе, являются только предложением и не должны 
быть полностью скопированы

• Для любого проекта важно правильно рассчитать время и вовремя подать завершенные 
рабочие результаты

## Инструкции для Участника

### 1.1 СОЗДАНИЕ БАЗЫ ДАННЫХ

Создайте базу данных с названием “Session1_XX” (где XX – номер вашего рабочего места) в 
предпочитаемой вами платформе (MySQL, Microsoft SQL Server или 1С). Это будет главная и 
единственная база данных в этой сессии.

### 1.2 ЗАГРУЗКА СТРУКТУРЫ БАЗЫ ДАННЫХ

В зависимости от предпочитаемой платформы, доступны SQL скрипты и выгрузка информационной 
базы для 1С. Данные скрипты и выгрузка состоят из структуры базы данных и данных требуемых для 
выполнения задания. Данные необходимо загрузить в базу данных, созданную для данной сессии под 
названием “Session1_XX”

Согласно инструкциям дизайнеров предоставленная структура базы данных для данной сессии не 
может быт изменена. Речь идет о удалении таблиц, добавлении или удалении любых полей в 
таблицах или изменении типа данных.

Для лучшего понимания структуры базы данных дизайнеры предоставили ERD. Выше приведенная 
диаграмма объясняет концепцию и модель данных, используемых в базе данных.

### 1.3 ЗАГРУЗКА ДАННЫХ О ПОЛЬЗОВАТЕЛЯХ
Руководство утвердило список пользователей которым необходим доступ в систему. Список 
предоставлен в файле “ UserData.csv”, его небходимо загрузить в таблицу “Users”

Список полей данных, которые должны быть загружены и на которые имеются поля в базе данных 
для каждого пользователя, следующие Role (Роль) , Email , Password , Firstname (Имя), Lastname
(Фамилия), Title (Должность), Birthdate (Дата рождения), and Active .

Пароли в файлах данных предоставляются в виде простого текста, но для лучшей безопасности 
должны быть сконвертированы в MD5. С этого момента пароли должны храниться в этом формате. 
Очевидно, что e-mail, используемый в качестве логина для входа в систему, должен быть 
уникальным.

### 1.4 ОТСЛЕЖИВАНИЕ АКТИВНОСТИ ПОЛЬЗОВАТЕЛЕЙ
Из-за политики безопасности AMONIC Airlines, компания попросила добавить в систему трекинг. Для 
этого требуется разработка дополнительн-ой(ых) таблиц(ы), которые будет необходимо включить в 
базу данных.
