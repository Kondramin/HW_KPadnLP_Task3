﻿using ConsoleInterface;
using FigureLib;
using System.Collections.Generic;
using System.Drawing;

namespace HW_KPLP_Task3
{
    /*
     * Задание 3. 
1.	Необходимо решить задачу, согласно варианта (таблица 3.1)
2.	При создании классов руководствоваться Code Convention
3.	Класс должен быть размещён в библиотеке классов.
4.	Весь код должен быть снабжён элементами документирования
5.	Сгенерировать XML-файл с документацией по проекту
6.	Подключить созданную библиотеку в консольное приложение
7.	Разработать модульные тесты для верификации созданного класса
8.	Класс должен быть размещён в библиотеке классов
9.	Модульные тесты – в отдельном проекте
10.	В отдельном проекте реализовать графический интерфейс: для чётных вариантов – Windows Presentation Foundation.


1.1 +	Создать иерархию классов для хранения прямоугольников и треугольников на плоскости.
1.2	+ Класс многоугольников должен быть абстрактным, содержать следующие элементы: 
        поля (вид многоугольника; массив, содержащий координаты вершин; цвет фигуры); 
        абстрактные методы вычисления площади и периметра фигуры; 
        метод вывода информации об объекте.
1.3	+ Классы прямоугольников и треугольников должны содержать переопределенные методы для вычисления площади.
1.4	+ Дополнительно создать класс, реализующий интерфейс IComparer.
1.5	Разработать программу, которая выполняет следующие действия:
−	+считывает информацию из текстового файла, каждая строка которого содержит координаты вершин 
        (для прямоугольника левого верхнего и правого нижнего углов) и цвет фигуры, например, для треугольника: 1 1 2 3 4 1 White;
−	+формирует на основании этой информации массив объектов базового класса иерархии;
−	выводит на экран всю информацию, при этом каждая строка выводится тем цветом, который указан в свойстве цвет.
−	сортирует массив в порядке возрастания площадей многоугольников и выводит отсортированный массив;
−	меняет цвет всех прямоугольных треугольников, расположенных во II четверти координатной плоскости, на зеленый и выводит измененный массив.
     */

    //sourcethree, софтина для git
    //gitbush

    //enum
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInterface1 ci = new ConsoleInterface1();
            ci.StartInterface();
        }
    }
}
