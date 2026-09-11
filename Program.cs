string myName = "Гаврилова Вероника";
string groupName = "ИСП-251";
int courseNumber = 2;
double averageGrade = 4.6;
bool isBudget = true;

Console.WriteLine( "Знакомство");
Console.WriteLine($"Студент: {myName}");
Console.WriteLine($"[pynna: {groupName}");
Console.WriteLine($"Kypc: {courseNumber}");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Бюджетное место: {isBudget}");


Console.WriteLine();
Console.WriteLine("Ремонт: комната");

double roomWidth = 3.5;
double roomLength = 4.2;

double roomArea = roomWidth * roomLength;
double roomPerimeter = (roomWidth + roomLength) * 2;

Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
Console.WriteLine($"Площадь: {roomArea} кв.м");
Console.WriteLine($"Периметр: {roomPerimeter} м");


Console.WriteLine();
Console.WriteLine( "Покупка ноутбука в рассрочку");

int laptopPrice = 65000;
int monthsCount = 12;
double interestRate = 0.08;

double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / monthsCount;

Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");


Console.WriteLine();
Console.WriteLine( "Внимание: деление int");

int totalStudents = 25;
int groupsCount = 4;

int studentsPerGroupWrong = totalStudents / groupsCount;
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;

Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");


Console.WriteLine();
Console.WriteLine("Способы собрать строку");

string firstName = "Анна";
string lastName = "Смирнова";

// Способ 1: конкатенация через оператор +
string fullNameConcat = firstName + " " + lastName;

// Способ 2: интерполяция через $""
string fullNameInterp = $"{firstName} {lastName}";

// Способ 3: метод string.Concat
string fullNameConcatMethod = string. Concat(firstName, " ", lastName);

Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameInterp);
Console.WriteLine(fullNameConcatMethod);
Console.WriteLine($"Всe три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");


Console.WriteLine();
Console.WriteLine("Константы");

const double VatRate = 0.20;
const string CollegeName = "ВФ ВолГУ";

double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);

Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}): {priceWithVat}");


Console.WriteLine();
Console.WriteLine("Константы");

// НДС и название вуза — фиксированные данные, которые не должны меняться
// во время работы программы, поэтому объявлены как const.
const double VatRate = 0.20;
const string CollegeName = "ВФ ВолГУ";

// Базовая цена может меняться, а цена с НДС вычисляется из неё и ставки налога,
// чтобы формула расчёта хранилась в одном месте.
double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);

// Выводим итоговую информацию для пользователя: вуз, цену без НДС
// и цену с НДС, где ставка показана в виде процента.
Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}): {priceWithVat}");



Console.WriteLine();
Console.WriteLine("Бюджет студента");

int scholarship = 6000;
int monthlyExpenses = 4500;

int moneyLeft = scholarship - monthlyExpenses;
Console.WriteLine($"Остаток за месяц: {moneyLeft}");

const int MonthsInSemester = 4;
int moneyLeftForSemester = moneyLeft * MonthsInSemester;
Console.WriteLine($"Остаток за семестр ({MonthsInSemester} мес.): {moneyLeftForSemester}");

