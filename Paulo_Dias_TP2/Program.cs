using System;
using System.ComponentModel;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System.Numerics;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;


namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(" Por favor entre o número do exercício correspondente: ");
                Console.WriteLine(" 1 - Cálculo de Idade Precisa");
                Console.WriteLine(" 2 - Dias até o Próximo Aniversário");
                Console.WriteLine(" 3 - Diferença Entre Duas Datas");
                Console.WriteLine(" 4 - Formulário de Cadastro Simples");
                Console.WriteLine(" 5 - Conversor de Temperatura");
                Console.WriteLine(" 6 - Cálculo de IMC");
                Console.WriteLine(" 7 - Verificador de Número Par ou Ímpar");
                Console.WriteLine(" 8 - Classificação de Nota Escolar");
                Console.WriteLine(" 9 - Calculadora de Salário Líquido (BR- SP)");
                Console.WriteLine(" 10 - Contagem Regressiva");
                Console.WriteLine(" 11 - Tabuada Interativa");
                Console.WriteLine(" 12 - Jogo de Adivinhação");

                Console.WriteLine();
                Console.WriteLine(" Sair ");

                Console.WriteLine();
                string exercise = Console.ReadLine().ToLower();

                if (exercise == "sair")
                {
                    break;
                }

                int.TryParse(exercise, out int CExercise);

                if (CExercise == 1)
                {
                    try
                    {
                        Age age = new();

                        while (true)
                        {

                            Console.WriteLine("Por favor digite sua data de nascimento (Formato DD/MM/AAAA): ");

                            string birthday = Console.ReadLine();

                            if (DateTime.TryParse(birthday, out DateTime CBirthday))
                            {
                                age.Ages(CBirthday);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Data fornecida Inválida, tente novamente!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    }
                }
                else if (CExercise == 2)
                {
                    try
                    {

                        Age age = new();

                        Console.WriteLine("Qual seu primeiro nome? ");
                        string name = Console.ReadLine();
                        Console.WriteLine();

                        while (true)
                        {
                            Console.WriteLine("Por favor entre sua data de nascimento (formato DD/MM/AAAA): ");
                            string birthday = Console.ReadLine();


                            if (DateTime.TryParse(birthday, out DateTime CBirthday))
                            {
                                age.Ages(CBirthday, name);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Por favor entre uma data válida!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    }
                }
                else if (CExercise == 3)
                {
                    try
                    {
                        Age age = new();

                        

                        while (true)
                        {
                            Console.WriteLine("Por favor digite uma data aleatória (Formato DD/MM/AAAA): ");
                            string firstDate = Console.ReadLine();

                            if (DateTime.TryParse(firstDate, out DateTime CFirstDate))
                            {
                                Console.WriteLine("Por favor digite outra data aleatória(Formato DD / MM / AAAA): ");
                                string secondDate = Console.ReadLine();

                                while (true)
                                {
                                    if (DateTime.TryParse(secondDate, out DateTime CSecondDate))
                                    {
                                        age.DifDate(CFirstDate, CSecondDate);

                                        break;
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Por favor entre uma data válida!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");

                    }
                }
                else if (CExercise == 4)
                {
                    try
                    {
                        Console.WriteLine("Agora vou coletar algumas informações suas!");

                        while (true)
                        {

                            Console.WriteLine();
                            Console.WriteLine("Por favor entre seu nome completo: ");
                            string fullName = Console.ReadLine();

                            if (!System.String.IsNullOrEmpty(fullName))
                            {
                                Console.WriteLine();
                                Console.WriteLine("Digite a sua idade (Somente úmero): ");
                                string age = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Digite seu numero de telefone com DDD (Formato XXX XXXXX-XXXX)");
                                string? phone = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Digite seu e-mail: ");
                                string? email = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine($"Dados registrados: \n " +
                                                    $"Nome: {fullName} \n " +
                                                    $"Idade: {(!System.String.IsNullOrEmpty(age) ? age : "N/D")} \n " +
                                                    $"Telefone: {(!System.String.IsNullOrEmpty(phone) ? phone : "N/D")} \n " +
                                                    $"Email: {(!System.String.IsNullOrEmpty(email) ? email : "N/D")}");
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Nenhum dado escrito!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu algum erro: {ex.Message}");
                    }
                }
                else if (CExercise == 5)
                {
                    try
                    {
                        while (true)
                        {

                            Console.WriteLine();
                            Console.WriteLine("Digite a temperatura em Graus Celcius: ");
                            string input = Console.ReadLine();

                            int? celcius;

                            if (int.TryParse(input, out int temp))
                            {
                                celcius = temp;

                                part2 conversion = new();
                                conversion.Conversion(celcius);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nenhum dado digitado ou inválido!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    }
                }
                else if (CExercise == 6)
                {
                    try
                    {
                        while (true)
                        {
                            Console.WriteLine("Digite seu peso: ");
                            string weight = Console.ReadLine();
                            Console.WriteLine();

                            if (int.TryParse(weight, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out int CWeight))
                            {
                                while (true)
                                {
                                    Console.WriteLine("Digite a sua altura: ");
                                    string height = Console.ReadLine();
                                    Console.WriteLine();

                                    if (double.TryParse(height, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double CHeight))
                                    {

                                        part2 BMICalculation = new();
                                        BMICalculation.BMICalculation(CWeight, CHeight);
                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Dado inválido, por favor digite um número válido");
                                    }

                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Dado inválido, por favor digite um número válido");
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    }


                }
                else if (CExercise == 7)
                {
                    try
                    {
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Digite um numero inteiro de sua preferencia: ");
                            Console.WriteLine();

                            int oddOrEven;

                            if (int.TryParse(Console.ReadLine(), out int value))
                            {
                                oddOrEven = value;

                                if (oddOrEven % 2 == 0)
                                {
                                    Console.WriteLine($"O valor {oddOrEven} se trata de um \"Par\".");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"O valor {oddOrEven} se trata de um \"Ímpar\".");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor digitado inválido.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    }


                }
                else if (CExercise == 8)
                {
                    try
                    {
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Digite sua nota escolar (Formato 1 - 10): ");
                            string value = Console.ReadLine();
                            Console.WriteLine();

                            if (double.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double nota))
                            {
                                if (nota >= 0.00 && nota <= 10.00)
                                {
                                    Part3 grade = new();
                                    grade.ScholarGrade(nota);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Valor fora do intervalo!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor digitado inválido.");
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    }
                }
                else if (CExercise == 9)
                {
                    try
                    {
                        while (true)
                        {
                            Console.WriteLine("Digite seu salário (Formato X.XX):");
                            string wage = Console.ReadLine();
                            Console.WriteLine();

                            if (double.TryParse(wage, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double CWage))
                            {
                                Part3 deduction = new();
                                deduction.WageDeductions(CWage);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Valor digitado inválido");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    }
                }
                else if (CExercise == 10)
                {

                    try
                    {
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Digite um número inteiro de sua preferência: ");
                            string number = Console.ReadLine();
                            Console.WriteLine();

                            if (int.TryParse(number, out int CNumber))
                            {
                                while (CNumber >= 0)
                                {
                                    Console.Write($"{CNumber}, ");
                                    CNumber--;
                                    if (CNumber == 0)
                                    {
                                        Console.Write($"{CNumber}.");
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");

                    }
                }
                else if (CExercise == 11)
                {
                    try
                    {
                        while (true)
                        {
                            Console.WriteLine("Digite um número inteiro: ");
                            string mult = Console.ReadLine();
                            Console.WriteLine();

                            if (int.TryParse(mult, out int CMult))
                            {
                                for (int i = 1; i <= 10; i++)
                                {
                                    Console.WriteLine($"{i} x {CMult} = {i * CMult}");
                                }
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Valor digitado inválido");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    }
                }
                else if (CExercise == 12)
                {
                    try
                    {
                        while(true)
                        {
                            System.Random random = new Random();
                            int value = random.Next(1, 101);

                            int count = 5;

                            while (count > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Faça um chute entre 1 e 100 (Você tem {count} tentativas): ");
                                string guess = Console.ReadLine();
                                Console.WriteLine();

                                if (int.TryParse(guess, out int CGuess))
                                {
                                    if (CGuess == value)
                                    {
                                        Console.WriteLine($"Muito bem, você acertou, o valor misterioso era {value}");
                                        break;
                                    }
                                    else if (CGuess < value)
                                    {
                                        Console.WriteLine($"Ainda não, o valor misterioso está pelo menos à {(value / CGuess)} valores acima");
                                        count--;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Não não, o valor misterioso está pelo menos à {(CGuess / value)} valores abaixo");
                                        count--;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Valor digitado inválido!");
                                }
                                if (count == 0)
                                {
                                    Console.WriteLine($"Infelizmente você perdeu. O valor misterioso era {value}.");
                                }
                            }
                            
                            break;
                        }
                    }
                    catch ( Exception ex )
                    {
                        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                    }


                }
            }
        }
    }
}