using System;
using System.Threading;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Crazy game = new Crazy();
            game.Run();
            game.Back();
          
        }
    }

    public class Crazy
    {
        public void Run()
        {
            // 크아 실행
            // 캐릭터 선택
            // 무엇을 할 것인가?
            // 맵 선택
            // 상점에 간다.


            // 맵 선택
            // - 전투를 한다

            // 상점에 가면 ?
            // - 무기, 포션을 살 수 있다.


            // 캐릭터을 나열
            // 배찌, 다오, 디지니

            

            // 유저는 체력, 물풍선, 속도를 갖고, 캐릭터별로 조금씩 다르다!

                int hp = 10;
                int waterstr = 0;
                int speed = 0;
                string player = "캐릭터";


            // 캐릭터 마다 가지고 있는 능력이 다르다.

                Console.WriteLine("크레이지 아케이드에 온걸 환영합니다~!");
                Console.WriteLine();

                Console.WriteLine("캐릭터를 고르세요!");
                Console.WriteLine();

                Console.WriteLine("1. 배찌 \t 2. 다오 \t 3. 디지니");
                var select = Console.ReadLine();

                if (select == "1")
                {
                    player = "배찌";
                    Console.WriteLine("배찌를 선택하셨습니다!");
                    hp = 500;
                    waterstr = 100;
                    speed = 5;
                }
                else if (select == "2")
                {
                    player = "다오";
                    Console.WriteLine("다오를 선택하셨습니다!");
                    hp = 300;
                    waterstr = 120;
                    speed = 3;
                }
                else if (select == "3")
                {
                    player = "디지니";
                    Console.WriteLine("디지니를 선택하셨습니다!");
                    hp = 400;
                    waterstr = 80;
                    speed = 10;
                }

            

           // 유저 능력치

                Thread.Sleep(1000);
                Console.WriteLine();

                Console.WriteLine("--- User Status ---");
                Console.WriteLine();

                Console.WriteLine("\n 캐릭터 : " + player);
                Console.WriteLine("\n HP : " + hp);
                Console.WriteLine("\n waterstr : " + waterstr);
                Console.WriteLine("\n Speed : " + speed);

                Thread.Sleep(2000);



        }
           public void Back()
            {

            // 유저의 선택을 제공

            
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("무엇을 할것인가요?");
            Console.WriteLine();

            Console.WriteLine("1. 맵 선택 \t  2. 상점");
            var select = Console.ReadLine();

            if (select == "1")
            {

                //맵을 선택시 맵 고르기

                Console.Clear();
                Console.WriteLine("맵을 선택해주세요!");
                Console.WriteLine();
                

                Console.WriteLine("1. 팩토리 \t 2. 무덤 \t 3. 캠프 \t 4. 나가기");
                
                select = Console.ReadLine();

                if (select == "1")
                {
                    Console.WriteLine("팩토리에 진입합니다!");

                }
                else if (select == "2")
                {
                   Console.WriteLine("무덤에 진입합니다!");

                }
                else if (select == "3")
                {

                   Console.WriteLine("캠프에 진입합니다.!");
                 }
                else if (select == "4")
                {

                    Crazy game = new Crazy();
                    game.Back();
                 
                 }
                
            }
                 else if (select == "2")
                 {
                   //상점 선택시
                     Console.WriteLine("상점에 진입합니다!");
                     Console.Clear();

                     Console.WriteLine("무기를 고르세요!");
                     Console.WriteLine();

                     Console.WriteLine("1. 물풍선 \t 2. 바늘 \t 3. 방패 \t 4. 나가기");
                     select = Console.ReadLine();

                if (select == "1")
                {

                    Console.WriteLine("물풍선을 구입하셨습니다!");

                }
                else if (select == "2")
                {
                    Console.WriteLine("바늘을 구입하셨습니다!");

                }
                else if (select == "3")
                {
                    Console.WriteLine("방패를 구입하셨습니다!");
                }
                else if (select == "4")
                {
                    Console.WriteLine("상점에서 나갔습니다!");

                    Crazy game = new Crazy();
                    game.Back();

                }
                 }
            
            }
      
        
    }
}