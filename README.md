# events-planner

тестовое задание для компании Directum

open .sln file: planner\Planner\Planner.sln
---
**рекомендации по тестированию:**

— создать базу данных, заменить connString в сроке 18 файла Database.cs;

— начать создавать событие, оставив поле с именем пустым. нажать кнопку Save.
ожидаемый результат: диалоговое окно с предупреждением.

— создать события, где разница между StartDate и временем тестирования будет меньше, чем значение в NotifyBeforeMinutes, нажать кнопку Refresh.
ожидаемый результат: слева спустя минуту (частота вызова таймера) должны появиться данные о созданных событиях.

— создать событие, длительность которого будет составлять (к примеру) час. начать создавать еще одно, которое начинается / заканчивается во время проведения первого.
ожидаемый результат: диалоговое окно с предупреждением.

— нажать у одного из событий кнопку Delete, а затем слева кнопку Refresh.
ожидаемый результат: появление диалогового окна с надписью "Deleted" и отсутствие этого события на экране после нажатия на Refresh.

— добавить событие, которое должно произойти через 2-3 минуты. NotifyBeforeMinutes указать больше (например, 10). нажать Refresh.
ожидаемый результат: появление слева нового события. после того, как наступил StartDate Этого события, оно должно исчезнуть из поля слева.

<b>P.S.</b>

начала работать с WinForms, делала это впервые и, должна сказать, было очень интересно — гуглить документацию, сталкиваться с неизвестным, снова гуглить, экспериментировать.

есть много недочетов (как по требованиям, так и от меня самой):

- [ ] не осуществлен поиск событий;

- [x] не реализован процесс изменения события;

- [x] события отображаются, будучи отсортированными по дате и времени начала события, НО они не разделены на "будущие" и "прошедшие";

- [ ] хочется обернуть все запросы к базе в try-catch;

- [ ] было бы здорово оформить это все в виде календаря, где на каждый день будут события (не стала копировать код 1 в 1 с туториалов на Youtube, брала оттуда лишь часть необходимой время от времени информации);

- [ ] не доделан момент с адаптацией размера составляющих формы при изменении размера окна;

- [x] обновить все шрифты до любимого Montserrat (причем классического, а не жирного с подчеркиванием - погуглить, как добавить его); - и все-таки получилось пока только до стандартного, что есть в ВинФормах :(
