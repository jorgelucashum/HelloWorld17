

namespace HelloWorld17
{
    class Calculator
    {
        //params:
        public static int Sum(params int[] numbers) // colocar 'params' antes de declarar o array vai avisar pro compilador que a função pode receber uma quantia variável de valores.
        {
            // Método para somar todos os valores.
            int sum = 0; 
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

    }
}
