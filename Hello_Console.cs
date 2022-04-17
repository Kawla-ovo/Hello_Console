using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //程序的开始
            RESTART:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();//这下面显示了一个大的Welcome
            Console.WriteLine("██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗██╗\n██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝██║\n██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗  ██║\n██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝  ╚═╝\n╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗██╗\n ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝╚═╝");
            Console.WriteLine("Welcome to here!What is your name?\nYou have two options:\nKawla..........My father:)\nAnother Name..........I do not know:(");
            string Str = Console.ReadLine();
            string Name = "Kawla";
            if(Str == Name)//到这里开始问问题
            {
                Console.WriteLine("██╗  ██╗███████╗██╗     ██╗      ██████╗            ██╗  ██╗ █████╗ ██╗    ██╗██╗      █████╗ ██╗\n██║  ██║██╔════╝██║     ██║     ██╔═══██╗           ██║ ██╔╝██╔══██╗██║    ██║██║     ██╔══██╗██║\n███████║█████╗  ██║     ██║     ██║   ██║           █████╔╝ ███████║██║ █╗ ██║██║     ███████║██║\n██╔══██║██╔══╝  ██║     ██║     ██║   ██║           ██╔═██╗ ██╔══██║██║███╗██║██║     ██╔══██║╚═╝\n██║  ██║███████╗███████╗███████╗╚██████╔╝    ▄█╗    ██║  ██╗██║  ██║╚███╔███╔╝███████╗██║  ██║██╗\n╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝ ╚═════╝     ╚═╝    ╚═╝  ╚═╝╚═╝  ╚═╝ ╚══╝╚══╝ ╚══════╝╚═╝  ╚═╝╚═╝");
                Console.WriteLine("Hello,Dr.Kawla!I am your little app.\nWhat do you want to do?\n1..........You can ask me a Question\n2..........Please go to the menu");
                string Str1 = Console.ReadLine();//这里有问题了，两个选项
                if(Str1 == "1")
                {
                    Console.WriteLine("QUESTION:\nDo you love me?\n1..........Sure,I love you very much!\n2..........Are you kidding me?You just a app!");
                    string Str2 = Console.ReadLine();
                    if(Str2 == "1")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        int A = 0,B = 15;
                        while(A < B)
                        {
                            A++;
                            Console.WriteLine("I Love You Too!");
                        }
                        string Str3 = Console.ReadLine();
                        if(Str3 == "Thank you"||Str3 == "Thanks"||Str3 == "thank you"||Str3 == "thanks")
                        {
                            Console.WriteLine("I am very happy!\nDo you want me to draw something for you?\n1...............Yes\n2...............No");
                            string Str4 = Console.ReadLine();
                            if(Str4 == "1")//这里会画一个爱心
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("        *********           *********\n    *****************   *****************\n   ***************************************\n *******************************************\n*********************************************\n*********************************************\n*********************************************\n*********************************************\n*********************************************\n*********************************************\n *******************************************\n  *****************************************\n   ***************************************\n    *************************************\n     ***********************************\n      *********************************\n        *****************************\n          *************************\n            *********************\n               ***************\n                  *********\n                     ***");
                                Console.WriteLine("Do you happy to day?");//这里再做一些选项
                            }
                            else
                            {
                                Console.WriteLine("I am so tierd,see you next time!:)");//用goto语句退出
                                goto END;

                            }
                        }
                        else if(Str3 == "Have a good day!")
                        {
                            Console.WriteLine("");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Really?You do not love me,I work so hard!\nIt is time to say goodbye!");
                    }

                }//这里写几个else if的语句
                else if (Str1 == "2")//这里是一个主菜单页面
                {
                    FIND1:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("███╗   ███╗███████╗███╗   ██╗██╗   ██╗\n████╗ ████║██╔════╝████╗  ██║██║   ██║\n██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║\n██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║\n██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝\n╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ ");
                    Console.WriteLine("So what do you want to do?\n1...............How old are you,kids?\n2...............I want to know when is it?\n3...............Open some websites\n4...............Play some games\n5...............Get beautiful wallpapers\n6...............Kawla write something for you\n7...............Give me a good sentence!");
                    string Str5 = Console.ReadLine();//这里做几个机器人可用的功能
                    if(Str5 == "1" )
                    {
                        Console.WriteLine("No way!You can not know my age!HAHA!");
                    }
                    else if (Str5 == "2")
                    {
                        Console.WriteLine(DateTime.Now.ToString());
                        Console.WriteLine("Today is a wonderful day!");
                    }
                    else if(Str5 == "3")
                    {
                        Console.WriteLine("WEBSITES\nWhich one do you want to open?\n1...............Bilibili\n2...............Google Translate\n3...............Github\n4...............iQiYi\n5...............CCTV\n6...............Microsoft Learn\n7...............QQmail\n8...............Gmail\n9...............Adobe\n10...............TaoBao\n11...............DouBan\n12...............CSDN\n13...............Unity\n14...............Steam\n15...............DouYin");
                        string Str7 = Console.ReadLine();
                        string title = "OK,I am opening the",last = "......";
                        switch(Str7)//这里是打开网站的地方
                        {
                            case "1":
                                Console.WriteLine(title + " Bilibili" + last);//下面打开bilibili
                                System.Diagnostics.Process.Start("explorer.exe", "https://www.bilibili.com/");
                            break;
                            case "2":
                                Console.WriteLine(title + " Google Translate" + last);
                                System.Diagnostics.Process.Start("explorer.exe","https://translate.google.cn");
                            break;
                            case "3":
                                Console.WriteLine(title + " Github" + last);
                                System.Diagnostics.Process.Start("explorer.exe","https://github.com/");
                            break;
                            case "4":
                                Console.WriteLine(title + " iQiYi" + last);
                                System.Diagnostics.Process.Start("explorer.exe","https://www.iqiyi.com/");
                            break;
                            case "5"://这里是看CCTV的地方
                                Console.WriteLine("CCTV LIST:\n1..........CCTV1\t2..........CCTV2\n3..........CCTV3\t4..........CCTV4\n5..........CCTV5\t5+..........CCTV5+\n6..........CCTV6\t7..........CCTV7\n8..........CCTV8\t9..........CCTV9\n10..........CCTV10\t11..........CCTV11\n12..........CCTV12\t13..........CCTV13\n14..........CCTV14\t15..........CCTV15\n16..........CCTV16\t17..........CCTV17");
                                string Tv = Console.ReadLine();
                                switch(Tv)
                                {
                                    case "1":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv1/");
                                    break;
                                    case "2":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv2/");
                                    break;
                                    case "3":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv3/");
                                    break;
                                    case "4":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv4/");
                                    break;
                                    case "5":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv5/");
                                    break;
                                    case "5+":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv5plus/");
                                    break;
                                    case "6":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv6/");
                                    break;
                                    case "7":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv7/");
                                    break;
                                    case "8":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv8/");
                                    break;
                                    case "9":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctvjilu/");
                                    break;
                                    case "10":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv10/");
                                    break;
                                    case "11":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv11/");
                                    break;
                                    case "12":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv12/");
                                    break;
                                    case "13":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv13/");
                                    break;
                                    case "14":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctvchild/");
                                    break;
                                    case "15":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv15/");
                                    break;
                                    case "16":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv16/");
                                    break;
                                    case "17":
                                    System.Diagnostics.Process.Start("explorer.exe","https://tv.cctv.com/live/cctv17/");
                                    break;
                                    default:
                                    Console.WriteLine("This show is not available here.:(\nDo you want to:\n1....................Menu\n....................Quit");
                                    string Do = Console.ReadLine();
                                    if(Do == "1")
                                    {
                                        Console.WriteLine("\f");
                                        goto FIND1;
                                    }
                                    else if(Do == "2")
                                    {
                                        Console.WriteLine("\f");
                                        goto END;
                                    }
                                    break;
                                }
                            break;
                            //这里做一些其他
                            case "6":
                                Console.WriteLine(title + " Microsoft Learn" + last);
                                System.Diagnostics.Process.Start("explorer.exe","https://docs.microsoft.com/zh-cn/learn/");
                            break;
                            case "7":
                                Console.WriteLine(title + " QQmail" + last);
                                System.Diagnostics.Process.Start("explorer.exe","https://mail.qq.com/");
                            break;
                            case "8":
                                Console.WriteLine(title + " Gmail" + last);
                                System.Diagnostics.Process.Start("explorer.exe","http://mail.google.com/");
                            break;
                            case "9":
                                Console.WriteLine(title + " Adobe" + last);
                                System.Diagnostics.Process.Start("explorer.exe","https://www.adobe.com/cn/");
                            break;
                            case "10":
                                Console.WriteLine(title + " TaoBao" + last);
                                System.Diagnostics.Process.Start("explorer.exe","https://ai.taobao.com/");
                            break;
                            case "11":
                                Console.WriteLine(title + " DouBan" + last);
                                System.Diagnostics.Process.Start("explorer.exe","https://www.douban.com/");
                            break;
                        }
                    }
                    else if(Str5 == "4")//玩一些小游戏
                    {
                        Console.WriteLine("You have some options:\n1...............Play dice games\n2...............Play website games\n");
                        String Aws = Console.ReadLine();
                        if(Aws == "1")
                        { 
                            Console.WriteLine("I am starting......");
                            Game:
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.WriteLine("\nIt's a dice game, try your score\nPress any key to continue");
                            Console.ReadKey();
                            Console.Clear();
                            Random roll = new Random();
                            int roll1 = roll.Next(0,33);
                            int roll2 = roll.Next(0,34);
                            int roll3 = roll.Next(0,35);
                            int roll4 = roll1 + roll2 +roll3;
                            Console.WriteLine("Your number is: "+ roll4);
                            if(roll4 < 10)
                            {
                                Console.WriteLine("You are a loser");
                            }
                            else if(roll4 == 52||roll4 == 66||roll4 == 88||roll4 == 99)//一个小彩蛋
                            {
                                Console.WriteLine("You are a lucky dog,have a good time:)");
                            }
                            else if(roll4 > 10 && roll4 < 40)
                            {
                                Console.WriteLine("It is just so so~");
                            }
                            else if(roll4 > 40 && roll4 < 90 && roll4 != 52 && roll4 != 66 && roll4 != 88)
                            {
                                Console.WriteLine("You are great!");
                            }
                            else if(roll4 > 90 && roll4 != 99)
                            {
                                Console.WriteLine("You are the best!");
                            }
                            Console.WriteLine("Do you want to play it again?\n1...............Yes\n2...............No,go back to menu\n3...............Quit");
                            string Str9 = Console.ReadLine();
                            if(Str9 == "1")
                            {
                                goto Game;
                            }
                            else if(Str9 == "2")
                            {
                                Console.WriteLine("Let us go!");
                                goto FIND1;
                            }
                            else if(Str9 == "3")
                            {
                                Console.WriteLine("Goodbye,see you next time!");
                                goto END;
                            }
                        }
                        else if(Aws == "2")//这里以后整理一些网页游戏
                        {
                            Console.WriteLine("What website games do you want to play?\n1...............Dreader");
                            String Str8 = Console.ReadLine();
                            switch(Str8)
                            {
                                case "1":
                                    Console.WriteLine("OK,Let us play it!HAHA");
                                    System.Diagnostics.Process.Start("explorer.exe","https://donitz.itch.io/dreader");
                                break;
                            }
                        }
                        else if(Aws == "3")//这里是一个彩虹猫游戏
                        {
                            int Sum = 0,Sam = 0;
                            while(Sum < 10)
                            {
                                Sum++;
                                Console.WriteLine(Sam + "% percent completed!");
                                Sam = Sam + 10;
                                System.Threading.Thread.Sleep(200);//这个语句来让循环语句变慢
                                if(Sam == 100)
                                {
                                    Console.WriteLine("Finished!");
                                    break;
                                }
                            }
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            
                            Console.WriteLine("█\n\n\n\n\n\n\n\n\n\n\n");
                            
                        }

                    }
                    else if(Str5 == "5")//这里以后再做一些
                    {
                        Console.WriteLine("I am bringing many great wallpapers for you......");
                        System.Diagnostics.Process.Start("explorer.exe","https://wall.alphacoders.com/");
                    }
                    else if(Str5 == "6")
                    {
                        Console.WriteLine("I am copying,please wait...");
                        int AA = 0,BB = 0;
                        while(AA < 20)
                        {
                            AA++;
                            BB = BB + 5;
                            Console.WriteLine("{0}%finished!",BB);
                            System.Threading.Thread.Sleep(100);
                            if(BB == 100)
                            {
                                Console.WriteLine("Finished!");
                                break;
                            }   
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.WriteLine("\fHello!My name is Kawla!\nI am a senior high school student in Hunan China.\nI am glad to tell something about me:\nI dream to be a compter programmer,so I always learned it,such as C#,Unity,Python.\nThis is my new project,so I make it carefully.\nYou know,I always make many projects,but they failed.");
                    }
                    else if(Str5 == "7")
                    {
                        Random dice = new Random();
                        int num = dice.Next(0,10);
                        switch(num)
                        {
                            case 1 :
                                Console.WriteLine("Never give up, Never lose the opportunity to succeed\n\n");
                                break;
                            case 2:
                                Console.WriteLine(" Never allow yourself to get discouraged and think that your life is insignificant and can’t make a change.\n\n");
                                break;
                            case 3:
                                Console.WriteLine("Make yourself a better person and know who you are before you try and know someone else and expect them to know you.\n\n");
                                break;
                            case 4:
                                Console.WriteLine("Victory won't come to me unless I go to it.\n\n");
                                break;
                            case 5:
                                Console.WriteLine("If they throw stones at you， don’t throw back， use them to build your own foundation instead.\n\n");
                                break;
                            case 6:
                                Console.WriteLine("Truth needs no colour; beauty ， no pencil.\n\n");
                                break;
                            case 7:
                                Console.WriteLine("Not everything that is faced can be changed, but nothing can be changed until it is faced.\n\n");
                                break;
                            case 8:
                                Console.WriteLine(" One's real value first lies in to what degree and what sense he set himself.\n\n");
                                break;
                            case 9:
                                Console.WriteLine("Real dream is the other shore of reality.\n\n");
                                break;
                            case 10:
                                Console.WriteLine("Never underestimate your power to change yourself!\n\n");
                                break;
                                default:
                                Console.WriteLine("Error!");
                                break;
                        }
                    }


                    Console.WriteLine("There's nothing here, do you want to?\n1...............Go back to menu\n2...............Restart the app\n3...............Quit");
                    string Str6 = Console.ReadLine();
                    if(Str6 == "1")
                    {
                        goto FIND1;//一个goto语句，来返回主菜单
                    }
                    else if(Str6 == "3")
                    {
                        Console.WriteLine("OK,see you next time!");
                        goto END;//来结束这个程序
                    }
                    else if(Str6 == "2")
                    {
                        Console.WriteLine("OK,I am restarting...");
                        goto RESTART;//重新运行这个程序，一个goto语句
                    }
                }
            }
            else
            {
                Console.WriteLine("You are not my father!Goodbye forever!");
            }
            END:
            Console.WriteLine(" ██████╗  ██████╗  ██████╗ ██████╗ ██████╗ ██╗   ██╗███████╗██╗\n██╔════╝ ██╔═══██╗██╔═══██╗██╔══██╗██╔══██╗╚██╗ ██╔╝██╔════╝██║\n██║  ███╗██║   ██║██║   ██║██║  ██║██████╔╝ ╚████╔╝ █████╗  ██║\n██║   ██║██║   ██║██║   ██║██║  ██║██╔══██╗  ╚██╔╝  ██╔══╝  ╚═╝\n╚██████╔╝╚██████╔╝╚██████╔╝██████╔╝██████╔╝   ██║   ███████╗██╗\n ╚═════╝  ╚═════╝  ╚═════╝ ╚═════╝ ╚═════╝    ╚═╝   ╚══════╝╚═╝");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
    }
}