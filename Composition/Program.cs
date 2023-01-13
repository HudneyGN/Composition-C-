// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Globalization;
using Composition.Entities;
using Composition.Entities.Enums;

Console.Write("Enter department's name: ");
string depName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.WriteLine("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.WriteLine("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine());

Department dept = new Department(depName);
Worker worker = new Worker(name, level, baseSalary, dept);

Console.WriteLine("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n; i++) {
    Console.WriteLine($"Enter #{i} contract data: ");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract (date, valuePerHour, hours);
    worker.AddContract(contract);
}

Console.WriteLine();

Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));
Console.WriteLine("name " + worker.Name);
Console.WriteLine("Departament: " + worker.Department.Name);
Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("f2", CultureInfo.InvariantCulture));
