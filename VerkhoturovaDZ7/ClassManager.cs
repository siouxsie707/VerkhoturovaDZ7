using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CompanyHierarchy;

namespace CompanyHierarchy
{
    public class Manager : Employee
    {
        public List<Employee> Subordinates { get; private set; } = new List<Employee>();

        public Manager(string name, string position) : base(name, position) { }

        public void AddSubordinate(Employee employee)
        {
            Subordinates.Add(employee);
        }

        public void AssignTaskToWorker(Task task, Worker worker)
        {
            if (Subordinates.Contains(worker))
            {
                task.AssignTask(worker);
            }
            else
            {
                Console.WriteLine($"Ошибка: {worker.Name} не подчинен менеджеру {Name}.");
            }
        }
    }
}
