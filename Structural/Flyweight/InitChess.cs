namespace Flyweight
{
    public class InitChess
    {
        Bing redBing1;
        Bing redBing2;
        Bing redBing3;
        Bing redBing4;
        Bing redBing5;
        Pao redPao1;
        Pao redPao2;
        Ju redJu1;
        Ju redJu2;
        Ma redMa1;
        Ma redMa2;
        Xiang redXiang1;
        Xiang redXiang2;
        Shi redShi1;
        Shi redShi2;
        Shuai redShuai;

        Bing blackBing1;
        Bing blackBing2;
        Bing blackBing3;
        Bing blackBing4;
        Bing blackBing5;
        Pao blackPao1;
        Pao blackPao2;
        Ju blackJu1;
        Ju blackJu2;
        Ma blackMa1;
        Ma blackMa2;
        Xiang blackXiang1;
        Xiang blackXiang2;
        Shi blackShi1;
        Shi blackShi2;
        Shuai blackShuai;

        public void Init()
        {
            var factory = new ChessFactory();
            var bing = "bing";
            var pao = "pao";
            var ju = "ju";
            var ma = "ma";
            var xiang = "xiang";
            var shi = "shi";
            var jiang = "shuai";
            //red
            var red = "red";
            redBing1 = factory.GetChess<Bing>(bing, red, new[] { 0, 4 });
            redBing2 = factory.GetChess<Bing>(bing, red, new[] { 2, 4 });
            redBing3 = factory.GetChess<Bing>(bing, red, new[] { 4, 4 });
            redBing4 = factory.GetChess<Bing>(bing, red, new[] { 6, 4 });
            redBing5 = factory.GetChess<Bing>(bing, red, new[] { 8, 4 });
            redPao1 = factory.GetChess<Pao>(pao, red, new[] { 1, 2 });
            redPao2 = factory.GetChess<Pao>(pao, red, new[] { 7, 2 });
            redJu1 = factory.GetChess<Ju>(ju, red, new[] { 0, 0 });
            redJu2 = factory.GetChess<Ju>(ju, red, new[] { 8, 0 });
            redMa1 = factory.GetChess<Ma>(ma, red, new[] { 1, 0 });
            redMa2 = factory.GetChess<Ma>(ma, red, new[] { 8, 0 });
            redXiang1 = factory.GetChess<Xiang>(xiang, red, new[] { 2, 0 });
            redXiang2 = factory.GetChess<Xiang>(xiang, red, new[] { 6, 0 });
            redShi1 = factory.GetChess<Shi>(shi, red, new[] { 3, 0 });
            redShi2 = factory.GetChess<Shi>(shi, red, new[] { 5, 0 });
            redShuai = factory.GetChess<Shuai>(jiang, red, new[] { 4, 0 });

            //black
            var black = "black";
            blackBing1 = factory.GetChess<Bing>(bing, black, new[] { 8, 6 });
            blackBing2 = factory.GetChess<Bing>(bing, black, new[] { 6, 6 });
            blackBing3 = factory.GetChess<Bing>(bing, black, new[] { 4, 6 });
            blackBing4 = factory.GetChess<Bing>(bing, black, new[] { 2, 6 });
            blackBing5 = factory.GetChess<Bing>(bing, black, new[] { 0, 6 });
            blackPao1 = factory.GetChess<Pao>(pao, black, new[] { 7, 7 });
            blackPao2 = factory.GetChess<Pao>(pao, black, new[] { 1, 7 });
            blackJu1 = factory.GetChess<Ju>(ju, black, new[] { 8, 9 });
            blackJu2 = factory.GetChess<Ju>(ju, black, new[] { 0, 9 });
            blackMa1 = factory.GetChess<Ma>(ma, black, new[] { 7, 9 });
            blackMa2 = factory.GetChess<Ma>(ma, black, new[] { 1, 9 });
            blackXiang1 = factory.GetChess<Xiang>(xiang, black, new[] { 6, 9 });
            blackXiang2 = factory.GetChess<Xiang>(xiang, black, new[] { 2, 9 });
            blackShi1 = factory.GetChess<Shi>(shi, black, new[] { 5, 9 });
            blackShi2 = factory.GetChess<Shi>(shi, black, new[] { 3, 9 });
            blackShuai = factory.GetChess<Shuai>(jiang, black, new[] { 4, 9 });
        }
    }
}
