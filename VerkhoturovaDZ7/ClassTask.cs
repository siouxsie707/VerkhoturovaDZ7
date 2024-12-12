using System;

namespace CompanyHierarchy
{
    public class Task
    {
        public string TaskName { get; set; }
        public Employee AssignedTo { get; set; }
        public string Type { get; set; }

        public void AssignTask(Employee employee)
        {
            if (employee == null || AssignedTo?.Name == employee.Name)
            {
                Console.WriteLine("Ошибка: задача не может быть назначена самому себе или на несуществующего сотрудника.");
                return;
            }
            AssignedTo = employee;
            Console.WriteLine($"Задача \"{TaskName}\" назначена {AssignedTo.Name} от {employee.Name}.");
        }

        public void CompleteTask()
        {
            Console.WriteLine($"{AssignedTo.Name} берет задачу \"{TaskName}\".");
        }
    }
}
