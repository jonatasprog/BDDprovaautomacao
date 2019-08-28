//using BDDprovaautomacao.utils;
//using FrameworkCsharp.Utils;
//using FrameworkSelenium.Drivers;
//using System;
//using TechTalk.SpecFlow;

//namespace BDDprovaautomacao.steps
//{
//    [Binding]
//    public static class GenericSteps
//    {
//        public static CsvDatapool datapool2 = new CsvDatapool(ProjConfig.GetPath("\\boticario-cosmos-aribabuying\\Datapools\\csv\\TipoDeFormularioParaCompraDiretaCsvDatapool.csv"));

//        [BeforeFeature]
//        public static void InitReport()
//        {
//            Report.Start("boticario-cosmos-aribabuying", true);
//        }

//        [Given(@"que acesso o Ariba Guided Buying")]
//        public static void GivenQueAcessoOAribaGuidedBuying()
//        {
//            Report.AddTestCase("boticario-cosmos-aribaguided", DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_FFF"));
//            Browser.OpenBrowser(BrowsersType.CHROME, "https://s1-2.ariba.com/gb/?realm=grupoboticario-T");
//        }

//        [Given(@"que acesso url correspondente")]
//        public static void QueAcessoUrlCorrespondente()
//        {
//            Browser.GetWebDriver().Navigate().GoToUrl(LerConfiguracoes.LerArqConf(datapool2.GetValue("TipoDeFormularioCompraDireta")));
//        }

//        [Given(@"que acesso o Ariba Buying")]
//        public static void QueAcessoOAribaBuying()
//        {
//            Report.AddTestCase("boticario-cosmos-aribabuying", DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_FFF"));
//            Browser.OpenBrowser(BrowsersType.CHROME, "https://grupoboticario-t.procurement.ariba.com/");
//        }

//        [Given(@"que inicio o Report ""(.*)""")]
//        public static void InicioOReport(string nomeReport)
//        {
//            Report.AddTestCase("boticario-cosmos-aribabuying", DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_FFF"));
//        }

//        [Then(@"finalizo o acesso ao Ariba")]
//        public static void FinalizoOAcessoAoAriba()
//        {
//            Browser.CloseBrowser();
//        }

//        [AfterScenario]
//        public static void CleanUp()
//        {
//            Report.End();
//        }

//        [AfterFeature]
//        public static void StopReport()
//        {
//            Report.Stop();
//        }
//    }
//}
