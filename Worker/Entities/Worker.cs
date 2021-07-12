using System;
using System.Collections.Generic;
using Worker.Entities.Enums;

namespace Worker.Entities
{
    class Worker
    {
        public string Nome { get; set; }
        public WorkerLevel Level { get; set; } // usando enumeracao
        public double BaseSalary { get; set; }
        public Department Departament { get; set; } // composicao de classes
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // instanciando a lista

        public Worker()
        {
        }

        public Worker(string nome, WorkerLevel level, double baseSalary, Department departament)
        {
            Nome = nome;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            this.Contracts.Add(contract); // adicionando contrato a lista
        }

        public void RemoveContract(HourContract contract)
        {
            this.Contracts.Remove(contract); // removendo contrato
        }

        public double Income(int year, int month) // somando o total do salario nesse mes
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts) //invoca a classe contrato e percorre a lista Contracts
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }


    }
}
