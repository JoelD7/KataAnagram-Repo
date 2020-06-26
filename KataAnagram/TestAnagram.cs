using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;


namespace KataAnagram{

    public class TestAnagramFinder{

        public List<string> words = new List<string>();


        public TestAnagramFinder(){
            
            words.Add("tar");
            words.Add("arc");
            words.Add("glean");
            words.Add("stressed");
            words.Add("state");
            words.Add("elbow");
            words.Add("taste");
            words.Add("cried");
            words.Add("cider");
            words.Add("dusty");
            words.Add("pairs");
            words.Add("chin");
            words.Add("study");
            words.Add("night ");
            words.Add("thing");
            words.Add("inch");
            words.Add("robed");
            words.Add("grab");
            words.Add("cat");
            words.Add("bored");
            words.Add("nerved");
            words.Add("below");
            words.Add("save");
            words.Add("vase");
            words.Add("angel");
            words.Add("car");
            words.Add("desserts");
            words.Add("rat");
            words.Add("brag");
            words.Add("act");
            words.Add("paris");
            words.Add("denver");
            words.Add("eight");
            words.Add("either");
            words.Add("election");
            words.Add("else");
            words.Add("employee");
            words.Add("end");
            words.Add("energy");
            words.Add("enjoy");
            words.Add("enough");
            words.Add("votes");
            words.Add("enter");
            words.Add("entire");
            words.Add("environment");
            words.Add("environmental");
            words.Add("especially");
            words.Add("establish");
            words.Add("even");
            words.Add("fried");
            words.Add("evening");
            words.Add("event");
            words.Add("ever");
            words.Add("stove");
            words.Add("every");
            words.Add("untied");
            words.Add("claim");
            words.Add("class");
            words.Add("fired");
            words.Add("clear");
            words.Add("clearly");
            words.Add("close");
            words.Add("coach");
            words.Add("cold");
            words.Add("collection");
            words.Add("college");
            words.Add("color");
            words.Add("come");
            words.Add("dog");
            words.Add("commercial");
            words.Add("common");
            words.Add("head");
            words.Add("health");
            words.Add("hear");
            words.Add("heart");
            words.Add("heat");
            words.Add("wolf");
            words.Add("heavy");
            words.Add("help");
            words.Add("her");
            words.Add("here");
            words.Add("herself");
            words.Add("high");
            words.Add("him");
            words.Add("himself");
            words.Add("united");
            words.Add("god");
            words.Add("teacher");
            words.Add("flow");
            words.Add("cheater");
            words.Add("break");
            words.Add("rebuild");
            words.Add("dice");
            words.Add("senator");
            words.Add("kitchen");
            words.Add("treason");
            words.Add("thicken");
            words.Add("builder");
            words.Add("baker");
            words.Add("iced");
            words.Add("vender");
        }

        [Fact]
        public void TestAnagram(){

            Dictionary<string, string> expected = new Dictionary<string, string>();
            expected.Add("art","tar, rat");
            expected.Add("acr","arc, car");
            expected.Add("aegln","glean, angel");
            expected.Add("deerssst","stressed, desserts");
            expected.Add("aestt","state, taste");
            expected.Add("below","elbow, below");
            expected.Add("cdeir","cried, cider");
            expected.Add("dstuy","dusty, study");
            expected.Add("aiprs","pairs, paris");
            expected.Add("chin","chin, inch");
            expected.Add("ghint","night , thing");
            expected.Add("bdeor","robed, bored");
            expected.Add("abgr","grab, brag");
            expected.Add("act","cat, act");
            expected.Add("deenrv","nerved, denver, vender");
            expected.Add("aesv","save, vase");
            expected.Add("eostv","votes, stove");
            expected.Add("defir","fried, fired");
            expected.Add("deintu","untied, united");
            expected.Add("dgo","dog, god");
            expected.Add("flow","wolf, flow");
            expected.Add("aceehrt","teacher, cheater");
            expected.Add("abekr","break, baker");
            expected.Add("bdeilur","rebuild, builder");
            expected.Add("cdei","dice, iced");
            expected.Add("aenorst","senator, treason");
            expected.Add("cehiknt","kitchen, thicken");

            AnagramFinder anagram = new AnagramFinder(words);    
            Dictionary<string, string> actual = anagram.GetAnagramGroups();
            Assert.Equal(expected, actual);    

        }   

        [Fact]
        public void TestLongestAnagrams(){
            AnagramFinder anagramFinder = new AnagramFinder(words);
            string expected = "stressed, desserts";
            string actual = anagramFinder.GetLongestAnagrams();
            Assert.Equal(expected, actual);
        }


}


}