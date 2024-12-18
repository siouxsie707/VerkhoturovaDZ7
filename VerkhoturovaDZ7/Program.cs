﻿using System;
using System.Collections.Generic;

namespace CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание менеджеров
            var ceo = new Manager("Тимур", "Генеральный директор");
            var financialDirector = new Manager("Рашид", "Финансовый директор");
            var automationDirector = new Manager("О Ильхам", "Директор по автоматизации");

            // Формирование структуры бухгалтерии
            var accountingChief = new Manager("Лукас", "Начальник бухгалтерии");
            financialDirector.AddSubordinate(accountingChief);

            // Формирование структуры отдела автоматизации
            var itDepartmentChief = new Manager("Оркадий", "Начальник ИТ");
            var itDepartmentDeputy = new Manager("Володя", "Зам.начальника ИТ");
            automationDirector.AddSubordinate(itDepartmentChief);
            automationDirector.AddSubordinate(itDepartmentDeputy);

            // Сектор системщиков
            var systemAdminsChief = new Manager("Ильшат", "Глава сектора системщиков");
            var systemAdminsDeputy = new Manager("Иваныч", "Зам.глава сектора системщиков");
            itDepartmentChief.AddSubordinate(systemAdminsChief);
            itDepartmentChief.AddSubordinate(systemAdminsDeputy);

            // Работники сектора системщиков
            var systemWorker1 = new Worker("Илья", "Системщик");
            var systemWorker2 = new Worker("Витя", "Системщик");
            var systemWorker3 = new Worker("Женя", "Системщик");
            systemAdminsChief.AddSubordinate(systemWorker1);
            systemAdminsChief.AddSubordinate(systemWorker2);
            systemAdminsChief.AddSubordinate(systemWorker3);

            // Сектор разработчиков
            var developersChief = new Manager("Сергей", "Глава сектора разработчиков");
            var developersDeputy = new Manager("Ляйсан", "Зам.глава сектора разработчиков");
            itDepartmentChief.AddSubordinate(developersChief);
            itDepartmentChief.AddSubordinate(developersDeputy);

            // Работники сектора разработчиков
            var developer1 = new Worker("Марат", "Разработчик");
            var developer2 = new Worker("Дина", "Разработчик");
            var developer3 = new Worker("Ильдар", "Разработчик");
            var developer4 = new Worker("Антон", "Разработчик");
            developersChief.AddSubordinate(developer1);
            developersChief.AddSubordinate(developer2);
            developersChief.AddSubordinate(developer3);
            developersChief.AddSubordinate(developer4);

            // Создание задач
            var tasks = new List<Task>()
            {
                new Task() { TaskName = "Настройка сети", Type = "системщики" },
                new Task() { TaskName = "Обновление ПО", Type = "системщики" },
                new Task() { TaskName = "Аудит безопасности", Type = "системщики" },
                new Task() { TaskName = "Составление отчета", Type = "разработчики" }
            };

            // Назначение задач
            foreach (var task in tasks)
            {
                if (task.Type == "системщики")
                {
                    // Назначение задач всем системщикам
                    systemAdminsChief.AssignTaskToWorker(task, systemWorker1);
                    systemAdminsChief.AssignTaskToWorker(task, systemWorker2);
                    systemAdminsChief.AssignTaskToWorker(task, systemWorker3);
                }
                else if (task.Type == "разработчики")
                {
                    // Назначение задач всем разработчикам
                    developersChief.AssignTaskToWorker(task, developer1);
                    developersChief.AssignTaskToWorker(task, developer2);
                    developersChief.AssignTaskToWorker(task, developer3);
                    developersChief.AssignTaskToWorker(task, developer4);
                }
            }

            // Завершение задач
            foreach (var task in tasks)
            {
                task.CompleteTask();
            }
        }
    }
}