# SpecGB_Kremen

В данной программе мы создали 3 метода:
1. медот InputArray , который позволяет заполнить массив вводом с клавиатуры, определяя массив размера переменной size,
которая так же задается пользователем вводом с клавиатуры.
2. метод PrintArray , который выводит в консоль массив в виде [1,2,3,4,5.....N].
3. метод SortedArray , который считает сколько элементов в первоначальном массиве размером меньше 3, и на основе этого числа создает новый массив,
который заполняет элементами первоначального массива, удовлетворяющие условию.

Структура такова :
1. Строки 6-7.Вводим с клавиатуры размер массива.
2. Строки 9-24. Создаем метод InputArray, который позволяет заполнять массив с клавиатуры и проводит валидацию на пустые строки. 
3. Строки 26-35. Создаем метод вывода массива PrintArray.
4. Строки 37-56. Создаем метод SortedArray, который создает новый массив, размерность которого посчитана циклом, и заполняет его подходящими
под условия элементами.
5. Строка 58 и 59. Объявляем два новых массива, один из которых заполняется с клавиатуры, а второй заполняется созданным нами методом на основе первого.
6. Строки 60-64. Печать массивов в консоль в формате ["первоначальный" ; "массив"] => ["сортированный" ; "массив"]
7. Строки 65 и 66. Просьба нажать любую кнопку для завершения программы средствами встроенного метода ReadKey.

Данная программа выполняет поставленную задачу (создать новый массив из строк, длина которых не превышает 3х символов).
