using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json;
using Tic_Tac_Toe;

namespace Desctop_tic_tac_toe
{
    public partial class Form1 : Form
    {
        //uri = "https://localhost:7091/GameField/" + firstIndex.ToString() + "/" + secondIndex.ToString();

        HttpClient client;
        


        Button[][] btns;

        GameField gameField;
        
        const string uriConnect = "https://localhost:7091/GameField";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new HttpClient();

            gameField = new GameField();



            btns = new Button[][]{ 
                new Button[]{ button1_1, button1_2, button1_3},
                new Button[]{ button2_1, button2_2, button2_3},
                new Button[]{ button3_1, button3_2, button3_3 }
            };



            label1.Text = "Ваш ход";


            //backgroundWorker1.RunWorkerAsync();


        }

        private void backgroundWorker1_DoWorkAsync(object sender, System.ComponentModel.DoWorkEventArgs e){

            while (true)
            {

                if (gameField.gameState == 1)
                    label1.Text = "Вы победили";
                else if (gameField.gameState == -1)
                    label1.Text = "Вы проиграли";
                else if (gameField.gameState == 0)
                    label1.Text = "Ничья";
                else if (gameField.gameState == 2)
                    label1.Text = "Пока никто не победил";

                Thread.Sleep(1000);
            }
      

        }


        private async void Buttons_Click(object sender, EventArgs e)
        {



            Button b = (Button)sender;

            var position = b.Name.Remove(0, 6);

            switch (position)
            {
                case "1_1":
                    gameField.field[0][0] = 1;
                    b.Text = "X";
                    break;
                case "1_2":
                    gameField.field[0][1] = 1;
                    b.Text = "X";
                    break;
                case "1_3":
                    gameField.field[0][2] = 1;
                    b.Text = "X";
                    break;
                case "2_1":
                    gameField.field[1][0] = 1;
                    b.Text = "X";
                    break;
                case "2_2":
                    gameField.field[1][1] = 1;
                    b.Text = "X";
                    break;
                case "2_3":
                    gameField.field[1][2] = 1;
                    b.Text = "X";
                    break;
                case "3_1":
                    gameField.field[2][0] = 1;
                    b.Text = "X";
                    break;
                case "3_2":
                    gameField.field[2][1] = 1;
                    b.Text = "X";
                    break;
                case "3_3":
                    gameField.field[2][2] = 1;
                    b.Text = "X";
                    break;
            }


            // using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uriConnect);

            //var response = await client.SendAsync(request);

            using var response = await client.PostAsJsonAsync(uriConnect, gameField);

            var gameField2 = await response.Content.ReadFromJsonAsync<GameField>(); //JsonSerializer.Deserialize<GameField>(response.Content.ReadAsStringAsync().Result);

            gameField = gameField2;

            Debug.WriteLine(gameField.gameState);

            

            if (gameField.gameState == 1)
                label1.Text = "Вы победили";
            else if (gameField.gameState == -1)
                label1.Text = "Вы проиграли";
            else if (gameField.gameState == 0)
                label1.Text = "Ничья";
            else if (gameField.gameState == 2)
                label1.Text = "Пока никто не победил";

            //if (gameField2 != null)
            //{
            //    gameField = gameField2;
            //}


            for (int i = 0; i < btns.Length; i++)
            {
                for (int j = 0; j < btns[i].Length; j++)
                {
                    if (gameField.field[i][j] == 1)
                        btns[i][j].Text = "X";
                    else if (gameField.field[i][j] == -1)
                        btns[i][j].Text = "O";
                }
            }
        }
    }
}