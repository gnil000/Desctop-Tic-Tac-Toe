
//функция определения победы/поражения/ничьей
using System.Net.Http.Json;
using System.Text.Json;
using Tic_Tac_Toe;

int GameOver(int[][] arr) { 
    //1 - победа
    //-1 - поражение
    //0 - ничья
    //2 - нихуя
    int sum = 0;
    for (int i = 0; i < 3; i++) { //проверка по горизонтали
        sum = 0;
        for(int j = 0; j < 3; j++)
            sum+=arr[i][j];

        if(sum == 3)
            return 1;
        else if(sum == -3)
            return -1;
    }
    for (int i = 0; i < 3; i++) //проверка по вертикали
    {
        sum = 0;
        for (int j = 0; j < 3; j++)
            sum += arr[j][i];

        if (sum == 3)
            return 1;
        else if (sum == -3)
            return -1;
    }

    sum = 0;
    for (int i =0; i < 3; i++) //проверка по главной диагонали
    {
        sum += arr[i][i];
        if (sum == 3)
            return 1;
        else if (sum == -3)
            return -1;
    }

    sum = 0;
    for (int i = 0; i <3; i++) //проверка по побочной диагонали
    {
        sum+=arr[i][2-i];
        if (sum == 3)
            return 1;
        else if (sum == -3)
            return -1;
    }


    foreach (var i in arr) //если остался нулевой элемент, значит партия не окончена
        foreach (var j in i)
            if (j == 0)
                return 2;

    return 0;
}

void SetMove(int first, int second, string who) {
    string position = first.ToString()+ "." + second.ToString();
    switch(position)
    {
        case "1.1":
            Console.SetCursorPosition(48, 6);
            Console.Write(who);
            break;
        case "1.2":
            Console.SetCursorPosition(54, 6);
            Console.Write(who);
            break;
        case "1.3":
            Console.SetCursorPosition(60, 6);
            Console.Write(who);
            break;
        case "2.1":
            Console.SetCursorPosition(48, 10);
            Console.Write(who);
            break;
        case "2.2":
            Console.SetCursorPosition(54, 10);
            Console.Write(who);
            break;
        case "2.3":
            Console.SetCursorPosition(60, 10);
            Console.Write(who);
            break;
        case "3.1":
            Console.SetCursorPosition(48, 14);
            Console.Write(who);
            break;
        case "3.2":
            Console.SetCursorPosition(54, 14);
            Console.Write(who);
            break;
        case "3.3":
            Console.SetCursorPosition(60, 14);
            Console.Write(who);
            break;
    }
}

void PaintGameResult(int res)
{
    Console.SetCursorPosition(0, 16);
    switch (res) {
        case 1:
            Console.WriteLine("Вы победили");
            break;
        case -1:
            Console.WriteLine("Вы проиграли");
            break;
        case 0:
            Console.WriteLine("Ничья");
            break;
        default:
            break;
    }
}

// X - игрок
// O - кампутер
int[][] field1 = { //массив имитирует игровое поле
    new int[] {1,-1,0},
    new int[] {1,-1,-1},
    new int[] {0,-1,1}
};

Console.WriteLine(GameOver(field1));

Console.ReadLine();

//+-+-+-+-+-+-+-РАЗМЕТКА ПОЛЯ-+-+-+-+-+-+-+-+
for (int i = 4; i < 20; i++) //столбец
{
    if (i % 4 == 0)
    {
        for (int j = 45; j < 64; j++) //строка
        {
            Console.SetCursorPosition(j, i);
            Console.WriteLine("-");
        }
    }
}

for (int i = 45; i < 65; i+=6) //строка
{
    for (int j = 5; j < 16; j++) {
        Console.SetCursorPosition(i, j);
        Console.WriteLine("|");
    }
}

//SetMove();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
//+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
Random rand = new Random();

//1 - игрок
//-1 - компьютер
//0 - пустая клетка
int[][] field = { //массив имитирует игровое поле
    new int[] {0,0,0},
    new int[] {0,0,0},
    new int[] {0,0,0}
};

Console.SetCursorPosition(0, 5);
for (int i = 0; i < field.Length; i++) //выводит матрицу на консоль
{
    for (int j = 0; j < field[i].Length; j++)
        Console.Write("{0}\t", field[i][j]);
    Console.WriteLine();
}

HttpClient client = new HttpClient();
string uri;//= "https://localhost:7091/GameField/1/1";
//HttpRequestMessage request = new HttpRequestMessage();

string move;
string[] moveArr = new string[2];
int firstIndex;
int secondIndex;
int gameResult;

while (true)
{
    Console.SetCursorPosition(0, 10);
    Console.WriteLine("Где бы вы хотели поставить крестик?\n1.1\t1.2\t1.3\n2.1\t2.2\t2.3\n3.1\t3.2\t3.3");
    Console.WriteLine();
    move = Console.ReadLine(); //ввод клетки на поле
    Console.SetCursorPosition(0,15);
    Console.WriteLine("   ");
    moveArr = move.Split("."); //разделение на два числа
    firstIndex = Convert.ToInt16(moveArr[0]);
    secondIndex = Convert.ToInt16(moveArr[1]);


    //+-+-+-+-+-+-+-+-+-+-ВЕБ МОМЕНТ-+-+-+-+-+-+-+-+-+-+-+-+

    uri = "https://localhost:7091/GameField/" + firstIndex.ToString() + "/" + secondIndex.ToString();

    using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);

    var response = await client.SendAsync(httpRequestMessage);

    var gameField = JsonSerializer.Deserialize<GameField>(response.Content.ReadAsStringAsync().Result);

    //if (gameField != null) {
    //    field = gameField.field;
    //    gameResult = gameField.gameState;
    //}
    //else
    gameResult = 2;

   // var response = await client.SendAsync(request);
    //var response = await client.GetAsync(uri);
    //string resultFromResponse = response.Content.ReadAsStringAsync().Result;
    //Console.WriteLine(resultFromResponse);

  
    PaintGameResult(gameResult);

    //+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+



    field[firstIndex-1][secondIndex-1] = 1;
    Console.SetCursorPosition(0, 5);
    for (int i = 0; i < field.Length; i++) //выводит матрицу на консоль
    {
        for (int j = 0; j < field[i].Length; j++)
            Console.Write("{0}\t", field[i][j]);
        Console.WriteLine();
    }
    //SetMove(firstIndex,secondIndex, "X");

    //+-+-+-+-+-+-+-+-+-+-ХОД КОМПЬЮТЕРА-+-+-+-+-+-+-+-+-+-+
    
    //do
    //{
    //    firstIndex = rand.Next(1, 4);
    //    secondIndex = rand.Next(1, 4);
    //} while (field[firstIndex-1][secondIndex-1] != 0);

    //field[firstIndex-1][secondIndex-1] = -1;

    //Thread.Sleep(1000);
    //SetMove(firstIndex, secondIndex, "O");

    //Console.SetCursorPosition(0, 5);
    //for (int i = 0; i < field.Length; i++) //выводит матрицу на консоль
    //{
    //    for (int j = 0; j < field[i].Length; j++)
    //        Console.Write("{0}\t", field[i][j]);
    //    Console.WriteLine();
    //}

    //+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+

    //Console.SetCursorPosition(0, 16);
    //int result = GameOver(field); //проверяет положение игры
    //if (result == 1)
    //{
    //    Console.WriteLine("Вы победили");
    //    break;
    //}
    //else if (result == -1)
    //{
    //    Console.WriteLine("Вы проиграли");
    //    break;
    //}
    //else if (result == 0)
    //{
    //    Console.WriteLine("Ничья");
    //    break;
    //}
}



Console.ReadLine();

Console.SetCursorPosition(0, 25);