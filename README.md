# **ПРОВЕРОЧНАЯ РАБОТА**

***ЗАДАЧА***

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

***РЕШЕНИЕ***

1. Задаем массив со значениями.

2. Создаем переменную count, в которую будет записываться количество строк, длина которых 3 символа и меньше.

3. Вычисляем количество строк, длинна которых меньше либо равна 3 символа.

    Для этого:
    *   Через цикл прогоняем все строки массива. 
    *   На каждом "круге" сверяем длину строки. 
    *   Если количество символов <= 3 увеличиваем на единицу значение нашей переменной count. 
    *   Если же длина >3, то "идем" на новый "круг" цикла.

4. Инициализируем массив результатов размером count.

5. Формируем массив с результатами.

6. Новым циклом "проходимся" по каждой строке и также сравниваем на каждом "круге" длину строки. Если длина <=3, в текущий массив добавлятся данная строка, уменьшаем count на единицу и повышаем счетчик цикла на один, в противном случае лишь увеличиваем счетчик цикла на один. 

7. Выводим исходный массив в консоль.

8. Выводим преобразованный массив.

