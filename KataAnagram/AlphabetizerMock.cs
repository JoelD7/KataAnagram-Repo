using System;
using System.Collections.Generic;
using System.Linq;

namespace KataAnagram
{
    public class AlphabetizerMock
    {
        public Dictionary<string, string> keys;

        public AlphabetizerMock()
        {
            keys = new Dictionary<string, string>();
            keys.Add("tar", "art");
            keys.Add("arc", "acr");
            keys.Add("glean", "aegln");
            keys.Add("stressed", "deerssst");
            keys.Add("state", "aestt");
            keys.Add("elbow", "below");
            keys.Add("taste", "aestt");
            keys.Add("cried", "cdeir");
            keys.Add("cider", "cdeir");
            keys.Add("dusty", "dstuy");
            keys.Add("pairs", "aiprs");
            keys.Add("chin", "chin");
            keys.Add("study", "dstuy");
            keys.Add("night ", "ghint");
            keys.Add("thing", "ghint");
            keys.Add("inch", "chin");
            keys.Add("robed", "bdeor");
            keys.Add("grab", "abgr");
            keys.Add("cat", "act");
            keys.Add("bored", "bdeor");
            keys.Add("nerved", "deenrv");
            keys.Add("below", "below");
            keys.Add("save", "aesv");
            keys.Add("vase", "aesv");
            keys.Add("angel", "aegln");
            keys.Add("car", "acr");
            keys.Add("desserts", "deerssst");
            keys.Add("rat", "art");
            keys.Add("brag", "abgr");
            keys.Add("act", "act");
            keys.Add("paris", "aiprs");
            keys.Add("denver", "deenrv");
            keys.Add("eight", "eghit");
            keys.Add("either", "eehirt");
            keys.Add("election", "ceeilnot");
            keys.Add("else", "eels");
            keys.Add("employee", "eeelmopy");
            keys.Add("end", "den");
            keys.Add("energy", "eegnry");
            keys.Add("enjoy", "ejnoy");
            keys.Add("enough", "eghnou");
            keys.Add("votes", "eostv");
            keys.Add("enter", "eenrt");
            keys.Add("entire", "eeinrt");
            keys.Add("environment", "eeimnnnortv");
            keys.Add("environmental", "aeeilmnnnortv");
            keys.Add("especially", "aceeillpsy");
            keys.Add("establish", "abehilsst");
            keys.Add("even", "eenv");
            keys.Add("fried", "defir");
            keys.Add("evening", "eeginnv");
            keys.Add("event", "eentv");
            keys.Add("ever", "eerv");
            keys.Add("stove", "eostv");
            keys.Add("every", "eervy");
            keys.Add("untied", "deintu");
            keys.Add("claim", "acilm");
            keys.Add("class", "aclss");
            keys.Add("fired", "defir");
            keys.Add("clear", "acelr");
            keys.Add("clearly", "acellry");
            keys.Add("close", "celos");
            keys.Add("coach", "accho");
            keys.Add("cold", "cdlo");
            keys.Add("collection", "cceillnoot");
            keys.Add("college", "ceegllo");
            keys.Add("color", "cloor");
            keys.Add("come", "cemo");
            keys.Add("dog", "dgo");
            keys.Add("commercial", "acceilmmor");
            keys.Add("common", "cmmno");
            keys.Add("head", "adeh");
            keys.Add("health", "aelhht");
            keys.Add("hear", "aehr");
            keys.Add("heart", "aehrt");
            keys.Add("heat", "aeht");
            keys.Add("wolf", "flow");
            keys.Add("heavy", "aehvy");
            keys.Add("help", "ehlp");
            keys.Add("her", "ehr");
            keys.Add("here", "eehr");
            keys.Add("herself", "eefhrls");
            keys.Add("high", "ghhi");
            keys.Add("him", "him");
            keys.Add("himself", "efhim");
            keys.Add("united", "deintu");
            keys.Add("god", "dgo");
            keys.Add("teacher", "aceehrt");
            keys.Add("flow", "flow");
            keys.Add("cheater", "aceehrt");
            keys.Add("break", "abekr");
            keys.Add("rebuild", "bdeilur");
            keys.Add("dice", "cdei");
            keys.Add("senator", "aenorst");
            keys.Add("kitchen", "cehiknt");
            keys.Add("treason", "aenorst");
            keys.Add("thicken", "cehiknt");
            keys.Add("builder", "bdeilur");
            keys.Add("baker", "abekr");
            keys.Add("iced", "cdei");
            keys.Add("vender", "deenrv");

        }

        public string Alphabetize(string word)
        {
            string value;
            keys.TryGetValue(word, out value);
            return value;
        }
       
    }
}