# Clean Slate Protocol

Программа позволяющая выполнять сценарии после ввода "пароля принуждения". Программа мимикрирует под приложение для заметок (блокнот).

## Установка

Windows:

```sh
1. Скопируйте файлы в любую папку
2. Запустите программу
```

## Первоначальная настройка

1. Отредактируйте файл settings.ini, где:
```sh
[CodesGroup]
EternityCode = Пароль для вывода окна настроек
ApocalypseCode = Код апокалипсиса
```
- EternityCode - Указанный код выведет окно с настройками программы. Вводить непосредственно в текстовое поле главного окна программы.
- ApocalypseCode - Введя данный код на клавиатуре (вне зависимости от приложения в котором находится пользователь) будет выполнен один из сценариев. Путь к сценариям указывается в Настройках.

## Команды
Встроенные команды. Используйте для управления различными функциями. Вводите команды непосредственно в текстовое поле главного окна программы.
- console - выводит консоль разработчика.

## TODO:
- Функционал сценариев и интерфейс управления сценариями в настройках.
- Система уведомлений о введении "кода принуждения" и интерфейс настроек.
- Бэкап файлов после введения "кода принуждения".

## История релизов

* 0.0.1
    * Work in progress

## Мета

Distributed under the XYZ license. See ``LICENSE`` for more information.

[https://github.com/yourname/github-link](https://github.com/cracer00/)
