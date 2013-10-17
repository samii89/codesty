
namespace Oct17T1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;

    public class SpaceBreaker : TokenBreaker
    {
        public void breakIntoTokens(ArrayList tokenList)
        {
            for (int i = 0; i < tokenList.Count; i++ )
            {
                Token token = (Token)tokenList[i];

                if(token.Type == TokenType.UNDEFINED)
                    continue;

                bool isEnd = false;

                for (int j = 0; j < token.Value.Length ; j++ )
                {
                    char c = token.Value[i];

                    if((c == ' ')){

                    }
                }
            }
        }
    }
}
