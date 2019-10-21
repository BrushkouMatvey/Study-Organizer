# Flow of events 
## Содержание

1. [Актёры](#actors)   
2. [Варианты использования](#use_cases) <br>      
2.1. [Зарегистрироваться](#sign_up)    
&nbsp;&nbsp;&nbsp;&nbsp;2.1.1. [Краткое описание](#short_description_1)   
&nbsp;&nbsp;&nbsp;&nbsp;2.1.2. [Основной поток событий](#main_stream_of_events_1)  
&nbsp;&nbsp;&nbsp;&nbsp;2.1.3. [Альтернативный поток событий](#alternative_stream_of_events_1) <br>  
2.2. [Войти в учётную запись](#log_in)      
&nbsp;&nbsp;&nbsp;&nbsp;2.2.1. [Краткое описание](#short_description_2)  
&nbsp;&nbsp;&nbsp;&nbsp;2.2.2. [Основной поток событий](#main_stream_of_events_2)  
&nbsp;&nbsp;&nbsp;&nbsp;2.2.3. [Альтернативный поток событий](#alternative_stream_of_events_2)  <br>   
2.3. [Выйти из учётной записи](#log_out)    
&nbsp;&nbsp;&nbsp;&nbsp;2.3.1. [Краткое описание](#short_description_3)  
&nbsp;&nbsp;&nbsp;&nbsp;2.3.2. [Основной поток событий](#main_stream_of_events_3)  
&nbsp;&nbsp;&nbsp;&nbsp;2.3.3. [Альтернативный поток событий](#alternative_stream_of_events_3) <br>      
2.4. [Просмотреть расписание](#view_schedule)  
&nbsp;&nbsp;&nbsp;&nbsp;2.4.1. [Краткое описание](#short_description_4)  
&nbsp;&nbsp;&nbsp;&nbsp;2.4.2. [Основной поток событий](#main_stream_of_events_4)  
&nbsp;&nbsp;&nbsp;&nbsp;2.4.3. [Альтернативный поток событий](#alternative_stream_of_events_4) <br>       
2.5. [Просмотреть домашнее задание](#view_homework)   
&nbsp;&nbsp;&nbsp;&nbsp;2.5.1. [Краткое описание](#short_description_5)  
&nbsp;&nbsp;&nbsp;&nbsp;2.5.2. [Основной поток событий](#main_stream_of_events_5)  
&nbsp;&nbsp;&nbsp;&nbsp;2.5.3. [Альтернативный поток событий](#alternative_stream_of_events_5) <br>  
2.6.  [Просмотреть событие](#view_event)   
&nbsp;&nbsp;&nbsp;&nbsp;2.6.1. [Краткое описание](#short_description_6)  
&nbsp;&nbsp;&nbsp;&nbsp;2.6.2. [Основной поток событий](#main_stream_of_events_6)  
&nbsp;&nbsp;&nbsp;&nbsp;2.6.3. [Альтернативный поток событий](#alternative_stream_of_events_6)<br>   
2.7. [Просмотреть заметку](#view_note)  
&nbsp;&nbsp;&nbsp;&nbsp;2.7.1. [Краткое описание](#short_description_7)  
&nbsp;&nbsp;&nbsp;&nbsp;2.7.2. [Основной поток событий](#main_stream_of_events_7)  
&nbsp;&nbsp;&nbsp;&nbsp;2.7.3. [Альтернативный поток событий](#alternative_stream_of_events_7) <br>  
2.8. [Добавить предмет в расписание](#add_schedule_item)  
&nbsp;&nbsp;&nbsp;&nbsp;2.8.1. [Краткое описание](#short_description_8)  
&nbsp;&nbsp;&nbsp;&nbsp;2.8.2. [Основной поток событий](#main_stream_of_events_8)  
&nbsp;&nbsp;&nbsp;&nbsp;2.8.3. [Альтернативный поток событий](#alternative_stream_of_events_8) <br>  
2.9. [Добавить заметку](#edd_note)  
&nbsp;&nbsp;&nbsp;&nbsp;2.9.1. [Краткое описание](#short_description_9)  
&nbsp;&nbsp;&nbsp;&nbsp;2.9.2. [Основной поток событий](#main_stream_of_events_9)  
&nbsp;&nbsp;&nbsp;&nbsp;2.9.3. [Альтернативный поток событий](#alternative_stream_of_events_9)  <br>  
2.10.  [Добавить событие](#add_event)   
&nbsp;&nbsp;&nbsp;&nbsp;2.10.1. [Краткое описание](#short_description_10)  
&nbsp;&nbsp;&nbsp;&nbsp;2.10.2. [Основной поток событий](#main_stream_of_events_10)  
&nbsp;&nbsp;&nbsp;&nbsp;2.10.3. [Альтернативный поток событий](#alternative_stream_of_events_10)  <br>   
2.11.  [Добавить домашнее задание](#add_homework)   
&nbsp;&nbsp;&nbsp;&nbsp;2.11.1. [Краткое описание](#short_description_11)  
&nbsp;&nbsp;&nbsp;&nbsp;2.11.2. [Основной поток событий](#main_stream_of_events_11)  
&nbsp;&nbsp;&nbsp;&nbsp;2.11.3. [Альтернативный поток событий](#alternative_stream_of_events_11) <br>  
2.12.  [Редактировать расписание](#edit_schedule)    
&nbsp;&nbsp;&nbsp;&nbsp;2.12.1. [Краткое описание](#short_description_12)  
&nbsp;&nbsp;&nbsp;&nbsp;2.12.2. [Основной поток событий](#main_stream_of_events_12)  
&nbsp;&nbsp;&nbsp;&nbsp;2.12.3. [Альтернативный поток событий](#alternative_stream_of_events_12) <br>   
2.13.  [Редактировать домашнее задание](#edit_homework)   
&nbsp;&nbsp;&nbsp;&nbsp;2.13.1. [Краткое описание](#short_description_13)  
&nbsp;&nbsp;&nbsp;&nbsp;2.13.2. [Основной поток событий](#main_stream_of_events_13)  
&nbsp;&nbsp;&nbsp;&nbsp;2.13.3. [Альтернативный поток событий](#alternative_stream_of_events_13)<br>     
2.14.  [Редактировать событие](#edit_event)  
&nbsp;&nbsp;&nbsp;&nbsp;2.14.1. [Краткое описание](#short_description_14)  
&nbsp;&nbsp;&nbsp;&nbsp;2.14.2. [Основной поток событий](#main_stream_of_events_14)  
&nbsp;&nbsp;&nbsp;&nbsp;2.14.3. [Альтернативный поток событий](#alternative_stream_of_events_14) <br>  
2.15.  [Редактировать заметку](#edit_note)   
&nbsp;&nbsp;&nbsp;&nbsp;2.15.1. [Краткое описание](#short_description_15)  
&nbsp;&nbsp;&nbsp;&nbsp;2.15.2. [Основной поток событий](#main_stream_of_events_15)  
&nbsp;&nbsp;&nbsp;&nbsp;2.15.3. [Альтернативный поток событий](#alternative_stream_of_events_15)
--- 


<a name="actors"> 

# 1. Актёры  

|Актёр|Описание|
|---|---|
|Анонимный пользователь|Пользователь, который не прошёл процесс авторизации в системе. Имеет частичный доступ к пользовательскому функционалу системы: может просматривать расписание, заметки, домашние задания, события.|
|Авторизованный пользователь|Пользователь, прошедший процесс авторизации в системе под своим именем или псевдонимом. Имеет полный доступ к пользовательскому функционалу системы: может просматривать, редактировать, удалять расписание, заметки, домашние задания, события.|


<a name="use_cases">  

# 2. Варианты использования 

<a name="sign_up">  

## 2.1. Зарегистрироваться  

<a name="short_description_1">  

### 2.1.1. Краткое описание
 Позволяет создать пользователю собственную учётную запись.
<a name="precondition_1">  

### 2.1.2. Основной поток событий 

<a name="alternative_stream_of_events_1">  

### 2.1.3. Альтернативный поток событий

<a name="postcondition_1">  

## 2.2. Войти в учётную запись   

<a name="short_description_2">

### 2.2.1. Краткое описание
Позволяет пользователю войти в приложение, используя собственную учётную запись.

<a name="main_stream_of_events_2">  

### 2.2.2. Основной поток событий

<a name="alternative_stream_of_events_2">  

### 2.2.3. Альтернативный поток событий 

<a name="log_out">  

## 2.3. Выйти из учётной записи  

<a name="short_description_3">  

### 2.3.1. Краткое описание
Позволяет пользователю перейти в статус анонимного пользователя.

<a name="main_stream_of_events_3">  

### 2.3.2. Основной поток событий 

<a name="alternative_stream_of_events_3">  

### 2.3.3. Альтернативный поток событий

<a name="view_schedule">  

## 2.4. Просмотреть расписание 

<a name="short_description_4">  

### 2.4.1. Краткое описание
Позволяет пользователю просматривать расписание на неделю. 

<a name="main_stream_of_events_4">  

### 2.4.2. Основной поток событий

<a name="alternative_stream_of_events_4">  

### 2.4.3. Альтернативный поток событий 

<a name="view_homework">  

## 2.5. Просмотреть домашнее задание  

<a name="short_description_5">  

### 2.5.1. Краткое описание
Позволяет пользователю просматривать домашнее задание на выбранный день недели.  

<a name="main_stream_of_events_5">  

### 2.5.2. Основной поток событий

<a name="alternative_stream_of_events_5">  

### 2.5.3. Альтернативный поток событий 

<a name="view_event">  

## 2.6.  Просмотреть событие   

<a name="short_description_6">  

### 2.6.1. Краткое описание
Позволяет пользователю просматривать события, выбрав определенную дату.

<a name="main_stream_of_events_6">  

### 2.6.2. Основной поток событий 

<a name="alternative_stream_of_events_6">  

### 2.6.3. Альтернативный поток событий 

<a name="view_note">  

## 2.7. Просмотреть заметку 

<a name="short_description_7">  

### 2.7.1. Краткое описание
Позволяет пользователю просмотреть текст заметки. 

<a name="main_stream_of_events_7">  

### 2.7.2. Основной поток событий 

<a name="alternative_stream_of_events_7">  

### 2.7.3. Альтернативный поток событий  

<a name="add_schedule_item">  

## 2.8. Добавить предмет в расписание 

<a name="short_description_8">  

### 2.8.1. Краткое описание 
Позволяет пользователю добавить предмет в расписание. Пользователь устнавливает предмет, кабинет, преподавателя. 

<a name="main_stream_of_events_8">  

### 2.8.2. Основной поток событий 

<a name="alternative_stream_of_events_8">  

### 2.8.3. Альтернативный поток событий

<a name="edd_note">  

## 2.9. Добавить заметку 

Позволяет пользователю записывать мысли, идеи и создавать списки таким образом, чтобы иметь к ним доступ в любой момент.

<a name="short_description_9">  

### 2.9.1. Краткое описание 

<a name="main_stream_of_events_9">  

### 2.9.2. Основной поток событий 

<a name="alternative_stream_of_events_9">  

### 2.9.3. Альтернативный поток событий

<a name="add_event">  

## 2.10.  Добавить событие   

<a name="short_description_10">  

### 2.10.1. Краткое описание
Позволяет пользователю добавлять специальные уведомления, напоминающие вам о чём-либо. 

<a name="main_stream_of_events_10">  

### 2.10.2. Основной поток событий 

<a name="alternative_stream_of_events_10">  

### 2.10.3. Альтернативный поток событий  

<a name="add_homework">  

## 2.11.  Добавить домашнее задание 

<a name="short_description_11"> 

### 2.11.1. Краткое описание  
Позволяет пользователю добавлять домашнее задание и прикреплять к нему фото.

<a name="main_stream_of_events_11">  

### 2.11.2. Основной поток событий

<a name="alternative_stream_of_events_11">  

### 2.11.3. Альтернативный поток событий

<a name="edit_schedule">  

## 2.12.  Редактировать расписание   

<a name="short_description_12"> 

### 2.12.1. Краткое описание 
Позволяет пользователю изменять/удалять предмет из расписания, менять кабинеты и преподавателей.

<a name="main_stream_of_events_12">  

### 2.12.2. Основной поток событий

<a name="alternative_stream_of_events_12">  

### 2.12.3. Альтернативный поток событий

<a name="edit_homework">  

## 2.13.  Редактировать домашнее задание   

<a name="short_description_13">  

### 2.13.1. Краткое описание
Позволяет пользователю изменять/удалять домашнее задание.

<a name="main_stream_of_events_13">  

### 2.13.2. Основной поток событий 

<a name="alternative_stream_of_events_13">  

### 2.13.3. Альтернативный поток событий

<a name="edit_event">  

## 2.14.  Редактировать событие 

<a name="short_description_14">  

### 2.14.1. Краткое описание 
Позволяет пользователю изменять текст события, его дату и время.

<a name="main_stream_of_events_14">  

### 2.14.2. Основной поток событий  

<a name="alternative_stream_of_events_14">  

### 2.14.3. Альтернативный поток событий 

<a name="edit_note">  

## 2.15.  Редактировать заметку  

<a name="short_description_15">  

### 2.15.1. Краткое описание 
Позволяет пользователю изменять текст заметки. 

<a name="main_stream_of_events_15">  

### 2.15.2. Основной поток событий 

<a name="alternative_stream_of_events_15">  

### 2.15.3. Альтернативный поток событий 
