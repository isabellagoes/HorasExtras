Console.WriteLine("------------ Horas Extras ------------\n");

Console.WriteLine($"Salario-hora de {12:C}, {300} horas, sendo {0,2} horas-extra, salário = {Salario(12, 300, 0):C}");
Console.WriteLine($"Salario-hora de {12:C}, {300} horas, sendo {20} horas-extra, salário = {Salario(12, 300, 20):C}");
Console.WriteLine($"Salario-hora de {24:C}, {300} horas, sendo {0,2} horas-extra, salário = {Salario(24, 300, 0):C}");
Console.WriteLine($"Salario-hora de {24:C}, {300} horas, sendo {20} horas-extra, salário = {Salario(24, 300, 20):C}");

double Salario(double SalarioHora, double HorasTotais, double HorasExtras)
{
    return (SalarioHora * (HorasTotais - HorasExtras)) + (SalarioHora * HorasExtras * 1.4);
}