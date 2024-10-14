# Chat Application Using gRPC

## P.S.
Проект студенческий и нацелен на конкретную реализацию клиент-серверного приложения в целях изучения технологий Protocol Buffer. Проект не несет в себе коммерческой ценности

## Описание
Данное приложение представляет собой реализацию чата на основе технологии gRPC. Оно позволяет пользователям отправлять и получать сообщения в режиме реального времени, используя протоколы высокой производительности и надежности.

## Особенности
- **gRPC:** Высокопроизводительный фреймворк, который использует HTTP/2 для передачи данных.
- **Простота в использовании:** Четкая структура файлов `.proto` для определения сервисов и сообщений.
- **Поддержка потоковых данных:** Возможность реализации как одноразовых, так и потоковых вызовов.
- **Кросс-языковая поддержка:** Возможность использования различных языков программирования.

## Установка
Для запуска приложения необходимо выполнить следующие шаги:

1. **Клонирование репозитория:**
   ```bash
   git clone https://github.com/ваш_пользователь/ваш_репозиторий.git
Сборка проекта: Перейдите в директорию проекта и соберите его с помощью вашей IDE или командной строки.

**Запуск сервера: Запустите серверный проект:**
   dotnet run --project GrpcService
   
Запуск клиента: Запустите клиентский проект:
   dotnet run --project Chat

##Использование
  При запуске клиент запрашивает имя пользователя.
  Пользователь может отправлять сообщения, которые будут видны всем подключенным клиентам.

##Лицензия
  Этот проект лицензируется на условиях MIT License - подробности можно найти в файле LICENSE.

##Контрибьюция
  Если вы хотите внести свой вклад в проект, пожалуйста, создайте форк репозитория, внесите изменения и отправьте pull request.

##Связь
  Если у вас есть вопросы, вы можете связаться со мной по электронной почте: ture2014@ya.ru.
