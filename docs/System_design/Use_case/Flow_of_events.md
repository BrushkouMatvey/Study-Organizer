# Flow of events 
## Содержание

1. [Актёры](#actors)   
2. [Варианты использования](#use_cases)   
2.1. [Зарегистрироваться](#sign_up)    
&nbsp;&nbsp;&nbsp;&nbsp;2.1.1. [Краткое описание](#short_description_1)  
&nbsp;&nbsp;&nbsp;&nbsp;2.1.2. [Предусловие](#precondition_1)  
&nbsp;&nbsp;&nbsp;&nbsp;2.1.3. [Основной поток событий](#main_stream_of_events_1)  
&nbsp;&nbsp;&nbsp;&nbsp;2.1.4. [Альтернативный поток событий](#alternative_stream_of_events_1)  
&nbsp;&nbsp;&nbsp;&nbsp;2.1.5. [Постусловия](#postcondition_1) <br>  
2.2. [Войти в учётную запись](#log_in)      
&nbsp;&nbsp;&nbsp;&nbsp;2.2.1. [Краткое описание](#short_description_2)  
&nbsp;&nbsp;&nbsp;&nbsp;2.2.2. [Предусловие](#precondition_2)  
&nbsp;&nbsp;&nbsp;&nbsp;2.2.3. [Основной поток событий](#main_stream_of_events_2)  
&nbsp;&nbsp;&nbsp;&nbsp;2.2.4. [Альтернативный поток событий](#alternative_stream_of_events_2)  
&nbsp;&nbsp;&nbsp;&nbsp;2.2.5. [Постусловия](#postcondition_2) <br>   
2.3. [Выйти из учётную запись](#log_out)    
&nbsp;&nbsp;&nbsp;&nbsp;2.3.1. [Краткое описание](#short_description_3)  
&nbsp;&nbsp;&nbsp;&nbsp;2.3.2. [Предусловие](#precondition_3)  
&nbsp;&nbsp;&nbsp;&nbsp;2.3.3. [Основной поток событий](#main_stream_of_events_3)  
&nbsp;&nbsp;&nbsp;&nbsp;2.3.4. [Альтернативный поток событий](#alternative_stream_of_events_3)  
&nbsp;&nbsp;&nbsp;&nbsp;2.3.5. [Постусловия](#postcondition_3) <br>     
2.4. [Просмотреть расписание](#view_schedule)  
&nbsp;&nbsp;&nbsp;&nbsp;2.4.1. [Краткое описание](#short_description_4)  
&nbsp;&nbsp;&nbsp;&nbsp;2.4.2. [Предусловие](#precondition_4)  
&nbsp;&nbsp;&nbsp;&nbsp;2.4.3. [Основной поток событий](#main_stream_of_events_4)  
&nbsp;&nbsp;&nbsp;&nbsp;2.4.4. [Альтернативный поток событий](#alternative_stream_of_events_4)  
&nbsp;&nbsp;&nbsp;&nbsp;2.4.5. [Постусловия](#postcondition_4)  <br>       
2.5. [Просмотреть домашнее задание](#view_homework)   
&nbsp;&nbsp;&nbsp;&nbsp;2.5.1. [Краткое описание](#short_description_5)  
&nbsp;&nbsp;&nbsp;&nbsp;2.5.2. [Предусловие](#precondition_5)  
&nbsp;&nbsp;&nbsp;&nbsp;2.5.3. [Основной поток событий](#main_stream_of_events_5)  
&nbsp;&nbsp;&nbsp;&nbsp;2.5.4. [Альтернативный поток событий](#alternative_stream_of_events_5)  
&nbsp;&nbsp;&nbsp;&nbsp;2.5.5. [Постусловия](#postcondition_5)   <br>  
2.6.  [Просмотреть событие](#view_event)   
&nbsp;&nbsp;&nbsp;&nbsp;2.6.1. [Краткое описание](#short_description_6)  
&nbsp;&nbsp;&nbsp;&nbsp;2.6.2. [Предусловие](#precondition_6)  
&nbsp;&nbsp;&nbsp;&nbsp;2.6.3. [Основной поток событий](#main_stream_of_events_6)  
&nbsp;&nbsp;&nbsp;&nbsp;2.6.4. [Альтернативный поток событий](#alternative_stream_of_events_6)  
&nbsp;&nbsp;&nbsp;&nbsp;2.6.5. [Постусловия](#postcondition_6)   <br>     
2.7. [Просмотреть заметку](#view_note)  
&nbsp;&nbsp;&nbsp;&nbsp;2.7.1. [Краткое описание](#short_description_7)  
&nbsp;&nbsp;&nbsp;&nbsp;2.7.2. [Предусловие](#precondition_7)  
&nbsp;&nbsp;&nbsp;&nbsp;2.7.3. [Основной поток событий](#main_stream_of_events_7)  
&nbsp;&nbsp;&nbsp;&nbsp;2.7.4. [Альтернативный поток событий](#alternative_stream_of_events_7)  
&nbsp;&nbsp;&nbsp;&nbsp;2.7.5. [Постусловия](#postcondition_7)    <br>  
2.8. [Добавить предмет в расписание](#add_schedule_item)  
&nbsp;&nbsp;&nbsp;&nbsp;2.8.1. [Краткое описание](#short_description_8)  
&nbsp;&nbsp;&nbsp;&nbsp;2.8.2. [Предусловие](#precondition_8)  
&nbsp;&nbsp;&nbsp;&nbsp;2.8.3. [Основной поток событий](#main_stream_of_events_8)  
&nbsp;&nbsp;&nbsp;&nbsp;2.8.4. [Альтернативный поток событий](#alternative_stream_of_events_8)  
&nbsp;&nbsp;&nbsp;&nbsp;2.8.5. [Постусловия](#postcondition_8)     <br>     
2.9. [Добавить заметку](#edd_note)   
&nbsp;&nbsp;&nbsp;&nbsp;2.9.1. [Краткое описание](#short_description_9)  
&nbsp;&nbsp;&nbsp;&nbsp;2.9.2. [Предусловие](#precondition_9)  
&nbsp;&nbsp;&nbsp;&nbsp;2.9.3. [Основной поток событий](#main_stream_of_events_9)  
&nbsp;&nbsp;&nbsp;&nbsp;2.9.4. [Альтернативный поток событий](#alternative_stream_of_events_9)  
&nbsp;&nbsp;&nbsp;&nbsp;2.9.5. [Постусловия](#postcondition_9)    <br>   
2.10.  [Добавить событие](#add_event)   
&nbsp;&nbsp;&nbsp;&nbsp;2.10.1. [Краткое описание](#short_description_10)  
&nbsp;&nbsp;&nbsp;&nbsp;2.10.2. [Предусловие](#precondition_10)  
&nbsp;&nbsp;&nbsp;&nbsp;2.10.3. [Основной поток событий](#main_stream_of_events_10)  
&nbsp;&nbsp;&nbsp;&nbsp;2.10.4. [Альтернативный поток событий](#alternative_stream_of_events_10)  
&nbsp;&nbsp;&nbsp;&nbsp;2.10.5. [Постусловия](#postcondition_10)   <br>    
2.11.  [Добавить домашнее задание](#add_homework)   
&nbsp;&nbsp;&nbsp;&nbsp;2.11.1. [Краткое описание](#short_description_11)  
&nbsp;&nbsp;&nbsp;&nbsp;2.11.2. [Предусловие](#precondition_11)  
&nbsp;&nbsp;&nbsp;&nbsp;2.11.3. [Основной поток событий](#main_stream_of_events_11)  
&nbsp;&nbsp;&nbsp;&nbsp;2.11.4. [Альтернативный поток событий](#alternative_stream_of_events_11)  
&nbsp;&nbsp;&nbsp;&nbsp;2.11.5. [Постусловия](#postcondition_11)   <br>    
2.12.  [Удалить предмет из расписания](#delete_schedule_item)   
&nbsp;&nbsp;&nbsp;&nbsp;2.12.1. [Краткое описание](#short_description_12)  
&nbsp;&nbsp;&nbsp;&nbsp;2.12.2. [Предусловие](#precondition_12)  
&nbsp;&nbsp;&nbsp;&nbsp;2.12.3. [Основной поток событий](#main_stream_of_events_12)  
&nbsp;&nbsp;&nbsp;&nbsp;2.12.4. [Альтернативный поток событий](#alternative_stream_of_events_12)  
&nbsp;&nbsp;&nbsp;&nbsp;2.12.5. [Постусловия](#postcondition_12)  <br>    
2.13.  [Удалить домашнее задание](#delete_homework)  
&nbsp;&nbsp;&nbsp;&nbsp;2.13.1. [Краткое описание](#short_description_13)  
&nbsp;&nbsp;&nbsp;&nbsp;2.13.2. [Предусловие](#precondition_13)  
&nbsp;&nbsp;&nbsp;&nbsp;2.13.3. [Основной поток событий](#main_stream_of_events_13)  
&nbsp;&nbsp;&nbsp;&nbsp;2.13.4. [Альтернативный поток событий](#alternative_stream_of_events_13)  
&nbsp;&nbsp;&nbsp;&nbsp;2.13.5. [Постусловия](#postcondition_13)   <br>    
2.14.  [Удалить событие](#delete_event)   
&nbsp;&nbsp;&nbsp;&nbsp;2.14.1. [Краткое описание](#short_description_14)  
&nbsp;&nbsp;&nbsp;&nbsp;2.14.2. [Предусловие](#precondition_14)  
&nbsp;&nbsp;&nbsp;&nbsp;2.14.3. [Основной поток событий](#main_stream_of_events_14)  
&nbsp;&nbsp;&nbsp;&nbsp;2.14.4. [Альтернативный поток событий](#alternative_stream_of_events_14)  
&nbsp;&nbsp;&nbsp;&nbsp;2.14.5. [Постусловия](#postcondition_14)  <br>    
2.15. [Удалить заметку](#delete_note)      
&nbsp;&nbsp;&nbsp;&nbsp;2.15.1. [Краткое описание](#short_description_15)  
&nbsp;&nbsp;&nbsp;&nbsp;2.15.2. [Предусловие](#precondition_15)  
&nbsp;&nbsp;&nbsp;&nbsp;2.15.3. [Основной поток событий](#main_stream_of_events_15)  
&nbsp;&nbsp;&nbsp;&nbsp;2.15.4. [Альтернативный поток событий](#alternative_stream_of_events_15)  
&nbsp;&nbsp;&nbsp;&nbsp;2.15.5. [Постусловия](#postcondition_15)  <br>  
2.16.  [Редактировать расписание](#edit_schedule)    
&nbsp;&nbsp;&nbsp;&nbsp;2.16.1. [Краткое описание](#short_description_16)  
&nbsp;&nbsp;&nbsp;&nbsp;2.16.2. [Предусловие](#precondition_16)  
&nbsp;&nbsp;&nbsp;&nbsp;2.16.3. [Основной поток событий](#main_stream_of_events_16)  
&nbsp;&nbsp;&nbsp;&nbsp;2.16.4. [Альтернативный поток событий](#alternative_stream_of_events_16)  
&nbsp;&nbsp;&nbsp;&nbsp;2.16.5. [Постусловия](#postcondition_16) <br>
2.17.  [Редактировать домашнее задание](#edit_homework)   
&nbsp;&nbsp;&nbsp;&nbsp;2.17.1. [Краткое описание](#short_description_17)  
&nbsp;&nbsp;&nbsp;&nbsp;2.17.2. [Предусловие](#precondition_17)  
&nbsp;&nbsp;&nbsp;&nbsp;2.17.3. [Основной поток событий](#main_stream_of_events_17)  
&nbsp;&nbsp;&nbsp;&nbsp;2.17.4. [Альтернативный поток событий](#alternative_stream_of_events_17)  
&nbsp;&nbsp;&nbsp;&nbsp;2.17.5. [Постусловия](#postcondition_17)   <br>   
2.18.  [Редактировать событие](#edit_event)  
&nbsp;&nbsp;&nbsp;&nbsp;2.18.1. [Краткое описание](#short_description_18)  
&nbsp;&nbsp;&nbsp;&nbsp;2.18.2. [Предусловие](#precondition_18)  
&nbsp;&nbsp;&nbsp;&nbsp;2.18.3. [Основной поток событий](#main_stream_of_events_18)  
&nbsp;&nbsp;&nbsp;&nbsp;2.18.4. [Альтернативный поток событий](#alternative_stream_of_events_18)  
&nbsp;&nbsp;&nbsp;&nbsp;2.18.5. [Постусловия](#postcondition_18) <br> 
2.19.  [Редактировать заметку](#edit_note)   
&nbsp;&nbsp;&nbsp;&nbsp;2.19.1. [Краткое описание](#short_description_19)  
&nbsp;&nbsp;&nbsp;&nbsp;2.19.2. [Предусловие](#precondition_19)  
&nbsp;&nbsp;&nbsp;&nbsp;2.19.3. [Основной поток событий](#main_stream_of_events_19)  
&nbsp;&nbsp;&nbsp;&nbsp;2.19.4. [Альтернативный поток событий](#alternative_stream_of_events_19)  
&nbsp;&nbsp;&nbsp;&nbsp;2.19.5. [Постусловия](#postcondition_19)  <br>  


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

<a name="precondition_1">  

### 2.1.2. Предусловие 

<a name="main_stream_of_events_1">  

### 2.1.3. Основной поток событий 

<a name="alternative_stream_of_events_1">  

### 2.1.4. Альтернативный поток событий

<a name="postcondition_1">  

### 2.1.5. Постусловия

<a name="log_in">  

## 2.2. Войти в учётную запись   

<a name="short_description_2">

### 2.2.1. Краткое описание

<a name="precondition_2">  

### 2.2.2. Предусловие 

<a name="main_stream_of_events_2">  

### 2.2.3. Основной поток событий

<a name="alternative_stream_of_events_2">  

### 2.2.4. Альтернативный поток событий 

<a name="postcondition_2">  

### 2.2.5. Постусловия

<a name="log_out">  

## 2.3. Выйти из учётную запись   

<a name="short_description_3">  

### 2.3.1. Краткое описание

<a name="precondition_3">  

### 2.3.2. Предусловие 

<a name="main_stream_of_events_3">  

### 2.3.3. Основной поток событий 

<a name="alternative_stream_of_events_3">  

### 2.3.4. Альтернативный поток событий

<a name="postcondition_3">  

### 2.3.5. Постусловия

<a name="view_schedule">  

## 2.4. Просмотреть расписание 

<a name="short_description_4">  

### 2.4.1. Краткое описание 

<a name="precondition_4">  

### 2.4.2. Предусловие 

<a name="main_stream_of_events_4">  

### 2.4.3. Основной поток событий

<a name="alternative_stream_of_events_4">  

### 2.4.4. Альтернативный поток событий 

<a name="sigpostcondition_4n_up">  

### 2.4.5. Постусловия

<a name="view_homework">  

## 2.5. Просмотреть домашнее задание  

<a name="short_description_5">  

### 2.5.1. Краткое описание 

<a name="precondition_5">  

### 2.5.2. Предусловие 

<a name="main_stream_of_events_5">  

### 2.5.3. Основной поток событий

<a name="alternative_stream_of_events_5">  

### 2.5.4. Альтернативный поток событий 

<a name="postcondition_5">  

### 2.5.5. Постусловия 

<a name="view_event">  

## 2.6.  Просмотреть событие   

<a name="short_description_6">  

### 2.6.1. Краткое описание

<a name="precondition_6">  

### 2.6.2. Предусловие 

<a name="main_stream_of_events_6">  

### 2.6.3. Основной поток событий 

<a name="alternative_stream_of_events_6">  

### 2.6.4. Альтернативный поток событий 

<a name="postcondition_6">  

### 2.6.5. Постусловия  

<a name="view_note">  

## 2.7. Просмотреть заметку 

<a name="short_description_7">  

### 2.7.1. Краткое описание

<a name="precondition_7">  

### 2.7.2. Предусловие  

<a name="main_stream_of_events_7">  

### 2.7.3. Основной поток событий 

<a name="alternative_stream_of_events_7">  

### 2.7.4. Альтернативный поток событий  

<a name="postcondition_7">  

### 2.7.5. Постусловия

<a name="add_schedule_item">  

## 2.8. Добавить предмет в расписание 

<a name="short_description_8">  

### 2.8.1. Краткое описание 

<a name="precondition_8">  

### 2.8.2. Предусловие]  

<a name="main_stream_of_events_8">  

### 2.8.3. Основной поток событий 

<a name="alternative_stream_of_events_8">  

### 2.8.4. Альтернативный поток событий

<a name="postcondition_8">  

### 2.8.5. Постусловия 

<a name="edd_note">  

## 2.9. Добавить заметку  

<a name="short_description_9">  

### 2.9.1. Краткое описание 

<a name="precondition_9">  

### 2.9.2. Предусловие 

<a name="main_stream_of_events_9">  

### 2.9.3. Основной поток событий 

<a name="alternative_stream_of_events_9">  

### 2.9.4. Альтернативный поток событий

<a name="postcondition_9">  

### 2.9.5. Постусловия 

<a name="add_event">  

## 2.10.  Добавить событие   

<a name="short_description_10">  

### 2.10.1. Краткое описание 

<a name="precondition_10">  

### 2.10.2. Предусловие 

<a name="main_stream_of_events_10">  

### 2.10.3. Основной поток событий 

<a name="alternative_stream_of_events_10">  

### 2.10.4. Альтернативный поток событий 

<a name="postcondition_10">  

### 2.10.5. Постусловия  

<a name="add_homework">  

## 2.11.  Добавить домашнее задание 

<a name="short_description_11">  

### 2.11.1. Краткое описание  

<a name="precondition_11">  

### 2.11.2. Предусловие 

<a name="main_stream_of_events_11">  

### 2.11.3. Основной поток событий

<a name="alternative_stream_of_events_11">  

### 2.11.4. Альтернативный поток событий

<a name="postcondition_11">  

### 2.11.5. Постусловия 

<a name="delete_schedule_item">  

## 2.12.  Удалить предмет из расписания 

<a name="short_description_12">  

### 2.12.1. Краткое описание

<a name="precondition_12">  

### 2.12.2. Предусловие 

<a name="main_stream_of_events_12">  

### 2.12.3. Основной поток событий

<a name="alternative_stream_of_events_12">  

### 2.12.4. Альтернативный поток событий 

<a name="postcondition_12">  

### 2.12.5. Постусловия 

<a name="delete_homework">  

## 2.13.  Удалить домашнее задание 

<a name="short_description_13">  

### 2.13.1. Краткое описание 

<a name="precondition_13">  

### 2.13.2. Предусловие 

<a name="main_stream_of_events_13">  

### 2.13.3. Основной поток событий  

<a name="alternative_stream_of_events_13">  

### 2.13.4. Альтернативный поток событий  

<a name="postcondition_13">  

### 2.13.5. Постусловия 

<a name="delete_event">  

## 2.14.  Удалить событие  

<a name="short_description_14">  

### 2.14.1. Краткое описание 

<a name="precondition_14">  

### 2.14.2. Предусловие 

<a name="main_stream_of_events_14">  

### 2.14.3. Основной поток событий  

<a name="alternative_stream_of_events_14">  

### 2.14.4. Альтернативный поток событий

<a name="postcondition_14">  

### 2.14.5. Постусловия  

<a name="delete_note">  

## 2.15. Удалить заметку     

<a name="short_description_15">  

### 2.15.1. Краткое описание 

<a name="precondition_15">  

### 2.15.2. Предусловие 

<a name="main_stream_of_events_15">  

### 2.15.3. Основной поток событий  

<a name="alternative_stream_of_events_15">  

### 2.15.4. Альтернативный поток событий

<a name="postcondition_15">  

### 2.15.5. Постусловия 

<a name="edit_schedule">  

## 2.16.  Редактировать расписание   

<a name="short_description_16">  

### 2.16.1. Краткое описание 

<a name="precondition_16">  

### 2.16.2. Предусловие 

<a name="main_stream_of_events_16">  

### 2.16.3. Основной поток событий

<a name="alternative_stream_of_events_16">  

### 2.16.4. Альтернативный поток событий

<a name="postcondition_16">  

### 2.16.5. Постусловия

<a name="edit_homework">  

## 2.17.  Редактировать домашнее задание   

<a name="short_description_17">  

### 2.17.1. Краткое описание

  <a name="precondition_17">  

### 2.17.2. Предусловие  

<a name="main_stream_of_events_17">  

### 2.17.3. Основной поток событий 

<a name="alternative_stream_of_events_17">  

### 2.17.4. Альтернативный поток событий

<a name="postcondition_17">  

### 2.17.5. Постусловия 

<a name="edit_event">  

## 2.18.  Редактировать событие 

<a name="short_description_18">  

### 2.18.1. Краткое описание 

<a name="precondition_18">  

### 2.18.2. Предусловие

<a name="main_stream_of_events_18">  

### 2.18.3. Основной поток событий  

<a name="alternative_stream_of_events_18">  

### 2.18.4. Альтернативный поток событий 

<a name="postcondition_18">  

### 2.18.5. Постусловия 

<a name="edit_note">  

## 2.19.  Редактировать заметку  

<a name="short_description_19">  

### 2.19.1. Краткое описание  

<a name="precondition_19">  

### 2.19.2. Предусловие](#precondition_19)  

<a name="main_stream_of_events_19">  

### 2.19.3. Основной поток событий 

<a name="alternative_stream_of_events_19">  

### 2.19.4. Альтернативный поток событий 

<a name="postcondition_19">  

### 2.19.5. Постусловия  
