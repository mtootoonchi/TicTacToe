using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;
using System.Text;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] NewFiles = { "N/A", "N/A", "N/A", "N/A", "N/A", "N/A" }; //Name : AI or Human : Diffeculty if aplicable : X : O : Ties
        string[][] SaveFilesArr = new string[3][];
        string Player = "N/A";
        string Difficulty = "N/A";
        SaveFileClass SaveFileClick = null;
        int SaveFileLocation = 0;
        char letter = 'X';
        public MainWindow()
        {
            InitializeComponent();
            SaveFilesArr[0] = new string[6];
            SaveFilesArr[1] = new string[6];
            SaveFilesArr[2] = new string[6];
            Start();
        }

        private void SaveFile1Load_Click(object sender, RoutedEventArgs e)
        {
            ClickTitle();
            SaveFileClick = new SaveFileClass(SaveFilesArr[0]);
            GameBoard();
            SaveFileLocation = 0;
        }

        private void SaveFile2Load_Click(object sender, RoutedEventArgs e)
        { 
            ClickTitle();
            SaveFileClick = new SaveFileClass(SaveFilesArr[1]);
            GameBoard();
            SaveFileLocation = 1;
        }

        private void SaveFile3Load_Click(object sender, RoutedEventArgs e)
        {
            ClickTitle();
            SaveFileClick = new SaveFileClass(SaveFilesArr[2]);
            GameBoard();
            SaveFileLocation = 2;
        }

        private void SaveFile1New_Click(object sender, RoutedEventArgs e)
        {
            ClickTitle();
            CreatingFile();
            SaveFileLocation = 0;    
        }

        private void SaveFile2New_Click(object sender, RoutedEventArgs e)
        {
            ClickTitle();
            CreatingFile();
            SaveFileLocation = 1;
        }

        private void SaveFile3New_Click(object sender, RoutedEventArgs e)
        {
            ClickTitle();
            CreatingFile();
            SaveFileLocation = 2;
        }

        private void SaveFile1Delete_Click(object sender, RoutedEventArgs e)
        {
            ClickTitle();
            File.WriteAllLines("SaveFile1.txt", NewFiles);
            Start();
        }

        private void SaveFile2Delete_Click(object sender, RoutedEventArgs e)
        {
            ClickTitle();
            File.WriteAllLines("SaveFile2.txt", NewFiles);
            Start();
        }

        private void SaveFile3Delete_Click(object sender, RoutedEventArgs e)
        {
            ClickTitle();
            File.WriteAllLines("SaveFile3.txt", NewFiles);
            Start();
        }

        private void ClickTitle()
        {
            Title.Visibility = Visibility.Collapsed;
            SaveFile1Load.Visibility = Visibility.Collapsed;
            SaveFile2Load.Visibility = Visibility.Collapsed;
            SaveFile3Load.Visibility = Visibility.Collapsed;
            SaveFile1New.Visibility = Visibility.Collapsed;
            SaveFile2New.Visibility = Visibility.Collapsed;
            SaveFile3New.Visibility = Visibility.Collapsed;
            SaveFile1Delete.Visibility = Visibility.Collapsed;
            SaveFile2Delete.Visibility = Visibility.Collapsed;
            SaveFile3Delete.Visibility = Visibility.Collapsed;
            SaveFile1.Visibility = Visibility.Collapsed;
            SaveFile2.Visibility = Visibility.Collapsed;
            SaveFile3.Visibility = Visibility.Collapsed;
        }

        private void Start()
        {
            if (!File.Exists("SaveFile1.txt"))
            {
                MessageBox.Show("SaveFile1 missing creating new SaveFile1.");
                File.WriteAllLines("SaveFile1.txt", NewFiles);
            }
            if (!File.Exists("SaveFile2.txt"))
            {
                MessageBox.Show("SaveFile2 missing creating new SaveFile2.");
                File.WriteAllLines("SaveFile2.txt", NewFiles);
            }
            if (!File.Exists("SaveFile3.txt"))
            {
                MessageBox.Show("SaveFile3 missing creating new SaveFile3.");
                File.WriteAllLines("SaveFile3.txt", NewFiles);
            }
            Title.Visibility = Visibility.Visible;
            SaveFile1Load.Visibility = Visibility.Visible;
            SaveFile2Load.Visibility = Visibility.Visible;
            SaveFile3Load.Visibility = Visibility.Visible;
            SaveFile1New.Visibility = Visibility.Visible;
            SaveFile2New.Visibility = Visibility.Visible;
            SaveFile3New.Visibility = Visibility.Visible;
            SaveFile1Delete.Visibility = Visibility.Visible;
            SaveFile2Delete.Visibility = Visibility.Visible;
            SaveFile3Delete.Visibility = Visibility.Visible;
            SaveFile1.Visibility = Visibility.Visible;
            SaveFile2.Visibility = Visibility.Visible;
            SaveFile3.Visibility = Visibility.Visible;
            TicTacToeBoard.Visibility = Visibility.Collapsed;
            LabelName.Visibility = Visibility.Collapsed;
            LabelPlayer.Visibility = Visibility.Collapsed;
            LabelDifficulty.Visibility = Visibility.Collapsed;
            ButtonAI.Visibility = Visibility.Collapsed;
            ButtonHuman.Visibility = Visibility.Collapsed;
            ButtonImpossible.Visibility = Visibility.Collapsed;
            ButtonEasy.Visibility = Visibility.Collapsed;
            ButtonCreateFile.Visibility = Visibility.Collapsed;
            SaveFileName.Visibility = Visibility.Collapsed;
            PlayerName.Visibility = Visibility.Collapsed;
            DifficultyName.Visibility = Visibility.Collapsed;
            Space1.Visibility = Visibility.Collapsed;
            Space2.Visibility = Visibility.Collapsed;
            Space3.Visibility = Visibility.Collapsed;
            Space4.Visibility = Visibility.Collapsed;
            Space5.Visibility = Visibility.Collapsed;
            Space6.Visibility = Visibility.Collapsed;
            Space7.Visibility = Visibility.Collapsed;
            Space8.Visibility = Visibility.Collapsed;
            Space9.Visibility = Visibility.Collapsed;
            X1.Visibility = Visibility.Collapsed;
            X2.Visibility = Visibility.Collapsed;
            X3.Visibility = Visibility.Collapsed;
            X4.Visibility = Visibility.Collapsed;
            X5.Visibility = Visibility.Collapsed;
            X6.Visibility = Visibility.Collapsed;
            X7.Visibility = Visibility.Collapsed;
            X8.Visibility = Visibility.Collapsed;
            X9.Visibility = Visibility.Collapsed;
            O1.Visibility = Visibility.Collapsed;
            O2.Visibility = Visibility.Collapsed;
            O3.Visibility = Visibility.Collapsed;
            O4.Visibility = Visibility.Collapsed;
            O5.Visibility = Visibility.Collapsed;
            O6.Visibility = Visibility.Collapsed;
            O7.Visibility = Visibility.Collapsed;
            O8.Visibility = Visibility.Collapsed;
            O9.Visibility = Visibility.Collapsed;
            Tie.Visibility = Visibility.Collapsed;
            SaveFilesArr[0] = File.ReadAllLines("SaveFile1.txt");
            SaveFilesArr[1] = File.ReadAllLines("SaveFile2.txt");
            SaveFilesArr[2] = File.ReadAllLines("SaveFile3.txt");
            if (IsDataCorruption(SaveFilesArr[0]))
            {
                MessageBox.Show("SaveFile1 corrupted creating new SaveFile1.");
                File.WriteAllLines("SaveFile1.txt", NewFiles);
                SaveFilesArr[0] = File.ReadAllLines("SaveFile1.txt");
            }
            if (IsDataCorruption(SaveFilesArr[1]))
            {
                MessageBox.Show("SaveFile2 corrupted creating new SaveFile2.");
                File.WriteAllLines("SaveFile2.txt", NewFiles);
                SaveFilesArr[1] = File.ReadAllLines("SaveFile2.txt");
            }
            if (IsDataCorruption(SaveFilesArr[2]))
            {
                MessageBox.Show("SaveFile3 corrupted creating new SaveFile3.");
                File.WriteAllLines("SaveFile3.txt", NewFiles);
                SaveFilesArr[2] = File.ReadAllLines("SaveFile3.txt");
            }
            SaveFile1.Content = "";
            SaveFile2.Content = "";
            SaveFile3.Content = "";
            for (int i = 0; i < 6; i++)
            {
                if (i == 3)
                {
                    SaveFile1.Content += "X: " + SaveFilesArr[0][i] + "   ";
                    SaveFile2.Content += "X: " + SaveFilesArr[1][i] + "   ";
                    SaveFile3.Content += "X: " + SaveFilesArr[2][i] + "   ";
                }
                else if (i == 4)
                {
                    SaveFile1.Content += "O: " + SaveFilesArr[0][i] + "   ";
                    SaveFile2.Content += "O: " + SaveFilesArr[1][i] + "   ";
                    SaveFile3.Content += "O: " + SaveFilesArr[2][i] + "   ";
                }
                else if (i == 5)
                {
                    SaveFile1.Content += "Ties: " + SaveFilesArr[0][i] + "   ";
                    SaveFile2.Content += "Ties: " + SaveFilesArr[1][i] + "   ";
                    SaveFile3.Content += "Ties: " + SaveFilesArr[2][i] + "   ";
                }
                else
                {
                    SaveFile1.Content += SaveFilesArr[0][i] + "   ";
                    SaveFile2.Content += SaveFilesArr[1][i] + "   ";
                    SaveFile3.Content += SaveFilesArr[2][i] + "   ";
                }
            }
        }


        private bool IsDataCorruption(string[] data)
        {
            if(data.Length != 6)
            {
                return true;
            }
            else if (!(data[1].Equals("AI") || data[1].Equals("Human") || data[1].Equals("N/A")))
            {
                return true;
            }
            else if(!(data[2].Equals("Impossible") || data[2].Equals("Average") || data[2].Equals("Easy") || data[2].Equals("N/A")))
            {
                return true;
            }
            else if(!(int.TryParse(data[3], out int waste) || data[3].Equals("N/A")))
            {
                return true;
            }
            else if(!(int.TryParse(data[4], out waste) || data[4].Equals("N/A")))
            {
                return true;
            }
            else if(!(int.TryParse(data[4], out waste) || data[4].Equals("N/A")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CreatingFile()
        {
            LabelName.Visibility = Visibility.Visible;
            LabelPlayer.Visibility = Visibility.Visible;
            LabelDifficulty.Visibility = Visibility.Visible;
            ButtonAI.Visibility = Visibility.Visible;
            ButtonHuman.Visibility = Visibility.Visible;
            ButtonCreateFile.Visibility = Visibility.Visible;
            SaveFileName.Visibility = Visibility.Visible;
            PlayerName.Visibility = Visibility.Visible;
            DifficultyName.Visibility = Visibility.Visible;
        }

        private void ButtonAI_Click(object sender, RoutedEventArgs e)
        {
            PlayerName.Content = "AI";
            ButtonImpossible.Visibility = Visibility.Visible;
            ButtonEasy.Visibility = Visibility.Visible;
            Player = "AI";
        }

        private void ButtonHuman_Click(object sender, RoutedEventArgs e)
        {
            PlayerName.Content = "Human";
            ButtonImpossible.Visibility = Visibility.Collapsed;
            ButtonEasy.Visibility = Visibility.Collapsed;
            DifficultyName.Content = "N/A";
            Difficulty = "N/A";
            Player = "Human";
        }

        private void ButtonImpossible_Click(object sender, RoutedEventArgs e)
        {
            DifficultyName.Content = "Impossible";
            Difficulty = "Impossible";
        }

        private void ButtonEasy_Click(object sender, RoutedEventArgs e)
        {
            DifficultyName.Content = "Easy";
            Difficulty = "Easy";
        }

        private void ButtonCreateFile_Click(object sender, RoutedEventArgs e)
        {
            if(SaveFileName.Text.Equals("") || PlayerName.Equals("N/A") || Player.Equals("AI") && Difficulty.Equals("N/A"))
            {
                MessageBox.Show("Please enter values.");
            }
            else if(Difficulty.Equals("Impossible"))
            {
                MessageBox.Show("Not made yet.");
            }
            else
            {
                string[] stuff = { SaveFileName.Text, Player, Difficulty, "0", "0", "0" };
                SaveFilesArr[SaveFileLocation] = stuff;
                SaveFileClick = new SaveFileClass(stuff);
                LabelName.Visibility = Visibility.Collapsed;
                LabelPlayer.Visibility = Visibility.Collapsed;
                LabelDifficulty.Visibility = Visibility.Collapsed;
                ButtonAI.Visibility = Visibility.Collapsed;
                ButtonHuman.Visibility = Visibility.Collapsed;
                ButtonImpossible.Visibility = Visibility.Collapsed;
                ButtonEasy.Visibility = Visibility.Collapsed;
                ButtonCreateFile.Visibility = Visibility.Collapsed;
                SaveFileName.Visibility = Visibility.Collapsed;
                PlayerName.Visibility = Visibility.Collapsed;
                DifficultyName.Visibility = Visibility.Collapsed;
                TicTacToeBoard.Visibility = Visibility.Visible;
                GameBoard();
            }
        }

        private void GameBoard()
        {
            Space1.Visibility = Visibility.Visible;
            Space2.Visibility = Visibility.Visible;
            Space3.Visibility = Visibility.Visible;
            Space4.Visibility = Visibility.Visible;
            Space5.Visibility = Visibility.Visible;
            Space6.Visibility = Visibility.Visible;
            Space7.Visibility = Visibility.Visible;
            Space8.Visibility = Visibility.Visible;
            Space9.Visibility = Visibility.Visible;
            TicTacToeBoard.Visibility = Visibility.Visible;
        }

        private void WipeGameBoard()
        {
            Space1.Visibility = Visibility.Collapsed;
            Space2.Visibility = Visibility.Collapsed;
            Space3.Visibility = Visibility.Collapsed;
            Space4.Visibility = Visibility.Collapsed;
            Space5.Visibility = Visibility.Collapsed;
            Space6.Visibility = Visibility.Collapsed;
            Space7.Visibility = Visibility.Collapsed;
            Space8.Visibility = Visibility.Collapsed;
            Space9.Visibility = Visibility.Collapsed;
            TicTacToeBoard.Visibility = Visibility.Collapsed;
            X1.Visibility = Visibility.Collapsed;
            X2.Visibility = Visibility.Collapsed;
            X3.Visibility = Visibility.Collapsed;
            X4.Visibility = Visibility.Collapsed;
            X5.Visibility = Visibility.Collapsed;
            X6.Visibility = Visibility.Collapsed;
            X7.Visibility = Visibility.Collapsed;
            X8.Visibility = Visibility.Collapsed;
            X9.Visibility = Visibility.Collapsed;
            O1.Visibility = Visibility.Collapsed;
            O2.Visibility = Visibility.Collapsed;
            O3.Visibility = Visibility.Collapsed;
            O4.Visibility = Visibility.Collapsed;
            O5.Visibility = Visibility.Collapsed;
            O6.Visibility = Visibility.Collapsed;
            O7.Visibility = Visibility.Collapsed;
            O8.Visibility = Visibility.Collapsed;
            O9.Visibility = Visibility.Collapsed;
            Scoreboard.Visibility = Visibility.Visible;
            Scoreboard.Content = "";
            for (int i = 0; i < 6; i++)
            {
                if (i == 3)
                {
                    Scoreboard.Content += "X: " + SaveFilesArr[SaveFileLocation][i] + "   ";
                }
                else if (i == 4)
                {
                    Scoreboard.Content += "O: " + SaveFilesArr[SaveFileLocation][i] + "   ";
                }
                else if (i == 5)
                {
                    Scoreboard.Content += "Ties: " + SaveFilesArr[SaveFileLocation][i] + "   ";
                }
                else
                {
                    Scoreboard.Content += SaveFilesArr[SaveFileLocation][i] + "   ";
                }
            }
        }

        private void AIPicked(int[] space)
        {
            letter = 'O';
            if (space[0] == 0 && space[1] == 0)
            {
                Space1.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X1.Visibility = Visibility.Visible;
                }
                else
                {
                    O1.Visibility = Visibility.Visible;
                }
            }
            else if (space[0] == 0 && space[1] == 1)
            {
                Space2.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X2.Visibility = Visibility.Visible;
                }
                else
                {
                    O2.Visibility = Visibility.Visible;
                }
            }
            else if (space[0] == 0 && space[1] == 2)
            {
                Space3.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X3.Visibility = Visibility.Visible;
                }
                else
                {
                    O3.Visibility = Visibility.Visible;
                }
            }
            else if (space[0] == 1 && space[1] == 0)
            {
                Space4.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X4.Visibility = Visibility.Visible;
                }
                else
                {
                    O4.Visibility = Visibility.Visible;
                }
            }
            else if (space[0] == 1 && space[1] == 1)
            {
                Space5.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X5.Visibility = Visibility.Visible;
                }
                else
                {
                    O5.Visibility = Visibility.Visible;
                }
            }
            else if (space[0] == 1 && space[1] == 2)
            {
                Space6.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X6.Visibility = Visibility.Visible;
                }
                else
                {
                    O6.Visibility = Visibility.Visible;
                }
            }
            else if (space[0] == 2 && space[1] == 0)
            {
                Space7.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X7.Visibility = Visibility.Visible;
                }
                else
                {
                    O7.Visibility = Visibility.Visible;
                }
            }
            else if (space[0] == 2 && space[1] == 1)
            {
                Space7.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X8.Visibility = Visibility.Visible;
                }
                else
                {
                    O8.Visibility = Visibility.Visible;
                }
            }
            else
            {
                Space9.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X9.Visibility = Visibility.Visible;
                }
                else
                {
                    O9.Visibility = Visibility.Visible;
                }
            }
            if (SaveFileClick.WhoWins() == 2)
            {
                SaveFilesArr[SaveFileLocation][3] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][3]));
                if (SaveFileLocation == 0)
                {
                    File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                }
                if (SaveFileLocation == 1)
                {
                    File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                }
                else
                {
                    File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                }
                WipeGameBoard();
                XWin.Visibility = Visibility.Visible;
                Wins.Visibility = Visibility.Visible;
                PlayAgain.Visibility = Visibility.Visible;
                Exit.Visibility = Visibility.Visible;
            }
            else if (SaveFileClick.WhoWins() == 1)
            {
                SaveFilesArr[SaveFileLocation][4] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][4]));
                if (SaveFileLocation == 0)
                {
                    File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                }
                if (SaveFileLocation == 1)
                {
                    File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                }
                else
                {
                    File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                }
                WipeGameBoard();
                OWin.Visibility = Visibility.Visible;
                Wins.Visibility = Visibility.Visible;
                PlayAgain.Visibility = Visibility.Visible;
                Exit.Visibility = Visibility.Visible;
            }
            else if (SaveFileClick.getPlays())
            {
                SaveFilesArr[SaveFileLocation][5] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][5]));
                if (SaveFileLocation == 0)
                {
                    File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                }
                if (SaveFileLocation == 1)
                {
                    File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                }
                else
                {
                    File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                }
                WipeGameBoard();
                Tie.Visibility = Visibility.Visible;
                PlayAgain.Visibility = Visibility.Visible;
                Exit.Visibility = Visibility.Visible;
            }
        }

        private void Space1_Click(object sender, RoutedEventArgs e)
        {
            letter = SaveFileClick.getLetter();
            if(SaveFileClick.place(0, 0))
            {
                Space1.Visibility = Visibility.Collapsed;
                if(letter == 'X')
                {
                    X1.Visibility = Visibility.Visible;
                }
                else
                {
                    O1.Visibility = Visibility.Visible;
                }
                if(SaveFileClick.WhoWins() == 2)
                {
                    SaveFilesArr[SaveFileLocation][3] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][3]));
                    if(SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    XWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.WhoWins() == 1)
                {
                    SaveFilesArr[SaveFileLocation][4] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][4]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    OWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if(SaveFileClick.getPlays())
                {
                    SaveFilesArr[SaveFileLocation][5] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][5]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    Tie.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if(SaveFilesArr[SaveFileLocation][1].Equals("AI"))
                {
                    AIPicked(SaveFileClick.AIplays());
                }
            }
        }

        private void Space2_Click(object sender, RoutedEventArgs e)
        {
            letter = SaveFileClick.getLetter();
            if (SaveFileClick.place(0, 1))
            {
                Space2.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X2.Visibility = Visibility.Visible;
                }
                else
                {
                    O2.Visibility = Visibility.Visible;
                }
                if (SaveFileClick.WhoWins() == 2)
                {
                    SaveFilesArr[SaveFileLocation][3] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][3]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    XWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.WhoWins() == 1)
                {
                    SaveFilesArr[SaveFileLocation][4] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][4]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    OWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.getPlays())
                {
                    SaveFilesArr[SaveFileLocation][5] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][5]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    Tie.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFilesArr[SaveFileLocation][1].Equals("AI"))
                {
                    AIPicked(SaveFileClick.AIplays());
                }
            }
        }

        private void Space3_Click(object sender, RoutedEventArgs e)
        {
            letter = SaveFileClick.getLetter();
            if (SaveFileClick.place(0, 2))
            {
                Space3.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X3.Visibility = Visibility.Visible;
                }
                else
                {
                    O3.Visibility = Visibility.Visible;
                }
                if (SaveFileClick.WhoWins() == 2)
                {
                    SaveFilesArr[SaveFileLocation][3] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][3]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    XWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.WhoWins() == 1)
                {
                    SaveFilesArr[SaveFileLocation][4] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][4]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    OWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.getPlays())
                {
                    SaveFilesArr[SaveFileLocation][5] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][5]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    Tie.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFilesArr[SaveFileLocation][1].Equals("AI"))
                {
                    AIPicked(SaveFileClick.AIplays());
                }
            }
        }

        private void Space4_Click(object sender, RoutedEventArgs e)
        {
            letter = SaveFileClick.getLetter();
            if (SaveFileClick.place(1, 0))
            {
                Space4.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X4.Visibility = Visibility.Visible;
                }
                else
                {
                    O4.Visibility = Visibility.Visible;
                }
                if (SaveFileClick.WhoWins() == 2)
                {
                    SaveFilesArr[SaveFileLocation][3] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][3]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    XWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.WhoWins() == 1)
                {
                    SaveFilesArr[SaveFileLocation][4] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][4]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    OWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.getPlays())
                {
                    SaveFilesArr[SaveFileLocation][5] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][5]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    Tie.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFilesArr[SaveFileLocation][1].Equals("AI"))
                {
                    AIPicked(SaveFileClick.AIplays());
                }
            }
        }

        private void Space5_Click(object sender, RoutedEventArgs e)
        {
            letter = SaveFileClick.getLetter();
            if (SaveFileClick.place(1, 1))
            {
                Space5.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X5.Visibility = Visibility.Visible;
                }
                else
                {
                    O5.Visibility = Visibility.Visible;
                }
                if (SaveFileClick.WhoWins() == 2)
                {
                    SaveFilesArr[SaveFileLocation][3] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][3]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    XWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.WhoWins() == 1)
                {
                    SaveFilesArr[SaveFileLocation][4] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][4]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    OWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.getPlays())
                {
                    SaveFilesArr[SaveFileLocation][5] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][5]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    Tie.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFilesArr[SaveFileLocation][1].Equals("AI"))
                {
                    AIPicked(SaveFileClick.AIplays());
                }
            }
        }

        private void Space6_Click(object sender, RoutedEventArgs e)
        {
            letter = SaveFileClick.getLetter();
            if (SaveFileClick.place(1, 2))
            {
                Space6.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X6.Visibility = Visibility.Visible;
                }
                else
                {
                    O6.Visibility = Visibility.Visible;
                }
                if (SaveFileClick.WhoWins() == 2)
                {
                    SaveFilesArr[SaveFileLocation][3] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][3]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    XWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.WhoWins() == 1)
                {
                    SaveFilesArr[SaveFileLocation][4] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][4]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    OWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.getPlays())
                {
                    SaveFilesArr[SaveFileLocation][5] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][5]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    Tie.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFilesArr[SaveFileLocation][1].Equals("AI"))
                {
                    AIPicked(SaveFileClick.AIplays());
                }
            }
        }

        private void Space7_Click(object sender, RoutedEventArgs e)
        {
            letter = SaveFileClick.getLetter();
            if (SaveFileClick.place(2, 0))
            {
                Space7.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X7.Visibility = Visibility.Visible;
                }
                else
                {
                    O7.Visibility = Visibility.Visible;
                }
                if (SaveFileClick.WhoWins() == 2)
                {
                    SaveFilesArr[SaveFileLocation][3] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][3]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    XWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.WhoWins() == 1)
                {
                    SaveFilesArr[SaveFileLocation][4] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][4]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    OWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.getPlays())
                {
                    SaveFilesArr[SaveFileLocation][5] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][5]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    Tie.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFilesArr[SaveFileLocation][1].Equals("AI"))
                {
                    AIPicked(SaveFileClick.AIplays());
                }
            }
        }

        private void Space8_Click(object sender, RoutedEventArgs e)
        {
            letter = SaveFileClick.getLetter();
            if (SaveFileClick.place(2, 1))
            {
                Space8.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X8.Visibility = Visibility.Visible;
                }
                else
                {
                    O8.Visibility = Visibility.Visible;
                }
                if (SaveFileClick.WhoWins() == 2)
                {
                    SaveFilesArr[SaveFileLocation][3] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][3]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    XWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.WhoWins() == 1)
                {
                    SaveFilesArr[SaveFileLocation][4] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][4]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    OWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.getPlays())
                {
                    SaveFilesArr[SaveFileLocation][5] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][5]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    Tie.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFilesArr[SaveFileLocation][1].Equals("AI"))
                {
                    AIPicked(SaveFileClick.AIplays());
                }
            }
        }

        private void Space9_Click(object sender, RoutedEventArgs e)
        {
            letter = SaveFileClick.getLetter();
            if (SaveFileClick.place(2, 2))
            {
                Space9.Visibility = Visibility.Collapsed;
                if (letter == 'X')
                {
                    X9.Visibility = Visibility.Visible;
                }
                else
                {
                    O9.Visibility = Visibility.Visible;
                }
                if (SaveFileClick.WhoWins() == 2)
                {
                    SaveFilesArr[SaveFileLocation][3] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][3]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    XWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.WhoWins() == 1)
                {
                    SaveFilesArr[SaveFileLocation][4] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][4]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    OWin.Visibility = Visibility.Visible;
                    Wins.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFileClick.getPlays())
                {
                    SaveFilesArr[SaveFileLocation][5] = "" + (1 + Convert.ToUInt32(SaveFilesArr[SaveFileLocation][5]));
                    if (SaveFileLocation == 0)
                    {
                        File.WriteAllLines("SaveFile1.txt", SaveFilesArr[0]);
                    }
                    if (SaveFileLocation == 1)
                    {
                        File.WriteAllLines("SaveFile2.txt", SaveFilesArr[1]);
                    }
                    else
                    {
                        File.WriteAllLines("SaveFile3.txt", SaveFilesArr[2]);
                    }
                    WipeGameBoard();
                    Tie.Visibility = Visibility.Visible;
                    PlayAgain.Visibility = Visibility.Visible;
                    Exit.Visibility = Visibility.Visible;
                }
                else if (SaveFilesArr[SaveFileLocation][1].Equals("AI"))
                {
                    AIPicked(SaveFileClick.AIplays());
                }
            }
        }

        private void ClearWinner()
        {
            Scoreboard.Visibility = Visibility.Collapsed;
            XWin.Visibility = Visibility.Collapsed;
            OWin.Visibility = Visibility.Collapsed;
            Wins.Visibility = Visibility.Collapsed;
            Tie.Visibility = Visibility.Collapsed;
            PlayAgain.Visibility = Visibility.Collapsed;
            Exit.Visibility = Visibility.Collapsed;
        }

        private void PlayAgain_Click(object sender, RoutedEventArgs e)
        {
            ClearWinner();
            ClickTitle();
            SaveFileClick = new SaveFileClass(SaveFilesArr[SaveFileLocation]);
            GameBoard();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ClearWinner();
            Start();
        }

        private void Title_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void SaveFile1_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void SaveFile2_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void SaveFile3_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void SaveFile1Load_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void SaveFile1New_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void SaveFile1Delete_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void SaveFile2Load_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void SaveFile2New_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void SaveFile2Delete_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void SaveFile3Load_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void SaveFile3New_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void SaveFile3Delete_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Image_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
        
        private void SaveFileName_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void PlayerName_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void DifficultyName_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Scoreboard_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
