using System;
using My_KidsBank_SpecFlow.Step_Def;
using NUnit.Framework;

namespace My_KidsBank_SpecFlow.Page_Test
{
    public class Login_Test
    {
        [Test]
        public void Login_Page_Tc1()
        {

            Login_Step_Def kb = new Login_Step_Def();
            kb.GivenUserShouldBeOnKidsbankLoginPage();
            kb.ThenEnterBanker_ID();
            kb.ThenEnterUserName();
            kb.ThenEnterTheUsr_Password();
            kb.ThenClickLogin_Button();


        }
    }
}
