using System;

namespace Catalogo.Domain.ValueObjects
{
    public class Dinheiro : ValueObject
    {
        public Dinheiro(decimal value)
        {
            Value = value;
        }

        public decimal Value { get; private set; }

        public static Dinheiro operator +(Dinheiro a) => a;
        public static Dinheiro operator +(Dinheiro a, Dinheiro b) => a + b;
        public static Dinheiro operator -(Dinheiro a) => -a;
        public static Dinheiro operator -(Dinheiro a, Dinheiro b) => a - b;

        public static Dinheiro operator /(Dinheiro a, Dinheiro b)
        {
            if (b.Value is 0) throw new DivideByZeroException("Operação inválida, o divisor não pode ser 0.");

            return a / b;
        }

    }
}
