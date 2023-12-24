using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenge43
{
    public class Challenge43 : BaseChallenge<long>
    {
        List<string> list1;
        List<string> list2;
        List<string> list3;
        List<string> list4;
        List<string> list5;
        List<string> list6;
        List<string> list7;

        public override string GetName()
        {
            return "Challenge43";
        }

        protected override void Setup()
        {
            this.list1 = new List<string>();
            this.list2 = new List<string>();
            this.list3 = new List<string>();
            this.list4 = new List<string>();
            this.list5 = new List<string>();
            this.list6 = new List<string>();
            this.list7 = new List<string>();

            this.FillList(this.list1, 2);
            this.FillList(this.list2, 3);
            this.FillList(this.list3, 5);
            this.FillList(this.list4, 7);
            this.FillList(this.list5, 11);
            this.FillList(this.list6, 13);
            this.FillList(this.list7, 17);
        }

        private void FillList(List<string> list, long multiplier)
        {
            for (int i = 1; i < 1000; i++)
            {
                string currNumAsString = (i * multiplier).ToString();
                if (currNumAsString.Length == 3)
                {
                    list.Add(currNumAsString);
                }
                else if (currNumAsString.Length == 2)
                {
                    list.Add("0" + currNumAsString);
                }
                else if (currNumAsString.Length == 1)
                {
                    list.Add("00" + currNumAsString);
                }
                else if (currNumAsString.Length > 3)
                {
                    return;
                }
            }
        }

        protected override long SolveImplementation()
        {
            long result = 0;
            string numberToCheck = "";
            for (int i = 0; i < 10; i++)
            {
                for (int list1Index = 1; list1Index < list1.Count; list1Index++)
                {
                    string str1 = this.list1[list1Index];
                    for (int list2Index = 0; list2Index < list2.Count; list2Index++)
                    {
                        string str2 = this.list2[list2Index];
                        if (str1[1] != str2[0] || str1[2] != str2[1])
                        {
                            continue;
                        }

                        for (int list3Index = 0; list3Index < list3.Count; list3Index++)
                        {
                            string str3 = this.list3[list3Index];
                            if (str2[1] != str3[0] || str2[2] != str3[1])
                            {
                                continue;
                            }
                            for (int list4Index = 0; list4Index < list4.Count; list4Index++)
                            {
                                string str4 = this.list4[list4Index];
                                if (str3[1] != str4[0] || str3[2] != str4[1])
                                {
                                    continue;
                                }
                                for (int list5Index = 0; list5Index < list5.Count; list5Index++)
                                {
                                    string str5 = this.list5[list5Index];
                                    if (str4[1] != str5[0] || str4[2] != str5[1])
                                    {
                                        continue;
                                    }
                                    for (int list6Index = 0; list6Index < list6.Count; list6Index++)
                                    {
                                        string str6 = this.list6[list6Index];
                                        if (str5[1] != str6[0] || str5[2] != str6[1])
                                        {
                                            continue;
                                        }
                                        for (int list7Index = 0; list7Index < list7.Count; list7Index++)
                                        {
                                            string str7 = this.list7[list7Index];
                                            if (str6[1] != str7[0] || str6[2] != str7[1])
                                            {
                                                continue;
                                            }

                                            numberToCheck = i.ToString();
                                            numberToCheck += str1;
                                            numberToCheck += str4;
                                            numberToCheck += str7;

                                            long parsedNumber = long.Parse(numberToCheck);
                                            if (parsedNumber.IsPandigital())
                                            {
                                                result += parsedNumber;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
