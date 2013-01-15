using System;
using System.Text;

namespace Hue.Generators {
    public class UserNameGenerator {
        private Random rand;

        public UserNameGenerator() {
            rand = new Random();
        }

        public string GenerateUserName() {
            return GenerateUserName(rand.Next(10, 20));
        }

        public string GenerateUserName(int length) {
            StringBuilder stringBuilder = new StringBuilder();

            for (int counter = 0; counter < length; counter++) {
                int value = rand.Next(0, 16);

                stringBuilder.AppendFormat("{0:X}", value);
            }

            return stringBuilder.ToString();
        }
    }
}
