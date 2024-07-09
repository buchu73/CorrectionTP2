﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestCalculScrutin.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("ScrutinMajoritaire", Description=@"	En tant que client de l'API à la clôture d'un scrutin
	Je souhaite calculer le résultat du scrutin
	Pour obtenir le vainqueur du vote

	- Pour obtenir un vainqueur, le scrutin doit être clôturé
	- Si un candidat obtient > 50% des voix, il est déclaré vainqueur
	- On veut pouvoir afficher le nombre de votes pour chaque candidat et le pourcentage correspondant à la clôture du scrutin.
	- Si aucun candidat n'a plus de 50%, alors on garde les 2 candidats correspondants aux meilleurs pourcentages et il y aura un deuxième tour de scrutin
	- Il ne peut y avoir que deux tours de scrutins maximums
	- Sur le dernier tour de scrutin, le vainqueur est le candidat ayant le pourcentage de vote le plus élevé
	- Si on a une égalité sur un dernier tour, on ne peut pas déterminer de vainqueur

	Evolution
	- Gestion des égalités sur le 2ème et 3ème candidat sur un premier tour
		- Règle métier choisie: en cas d'égalité au premier tour, le candidat le plus âgé est qualifié au deuxième tour
	- Gestion du vote blanc
		- Règle métier choisie: les votes blancs ou nuls ne sont pas comptabilisés dans les suffrages exprimés
								, mais ils sont décomptés à part et on veut pouvoir en connaître le nombre pour chaque tour ", SourceFile="Features\\Scrutin.feature", SourceLine=0)]
    public partial class ScrutinMajoritaireFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Scrutin.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ScrutinMajoritaire", @"	En tant que client de l'API à la clôture d'un scrutin
	Je souhaite calculer le résultat du scrutin
	Pour obtenir le vainqueur du vote

	- Pour obtenir un vainqueur, le scrutin doit être clôturé
	- Si un candidat obtient > 50% des voix, il est déclaré vainqueur
	- On veut pouvoir afficher le nombre de votes pour chaque candidat et le pourcentage correspondant à la clôture du scrutin.
	- Si aucun candidat n'a plus de 50%, alors on garde les 2 candidats correspondants aux meilleurs pourcentages et il y aura un deuxième tour de scrutin
	- Il ne peut y avoir que deux tours de scrutins maximums
	- Sur le dernier tour de scrutin, le vainqueur est le candidat ayant le pourcentage de vote le plus élevé
	- Si on a une égalité sur un dernier tour, on ne peut pas déterminer de vainqueur

	Evolution
	- Gestion des égalités sur le 2ème et 3ème candidat sur un premier tour
		- Règle métier choisie: en cas d'égalité au premier tour, le candidat le plus âgé est qualifié au deuxième tour
	- Gestion du vote blanc
		- Règle métier choisie: les votes blancs ou nuls ne sont pas comptabilisés dans les suffrages exprimés
								, mais ils sont décomptés à part et on veut pouvoir en connaître le nombre pour chaque tour ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Scrutin majoritaire, deux candidats un électeur et un vainqueur", SourceLine=20)]
        public virtual void ScrutinMajoritaireDeuxCandidatsUnElecteurEtUnVainqueur()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scrutin majoritaire, deux candidats un électeur et un vainqueur", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 21
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "DateDeNaissance"});
                table1.AddRow(new string[] {
                            "candidat 1",
                            "Jan 1, 1999"});
                table1.AddRow(new string[] {
                            "candidat 2",
                            "Jun 15, 1995"});
#line 22
 testRunner.Given("les candidats suivants", ((string)(null)), table1, "Given ");
#line hidden
#line 26
 testRunner.And("le tour de scrutin est ouvert", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote"});
                table2.AddRow(new string[] {
                            "candidat 1",
                            "1"});
#line 27
 testRunner.And("le vote des electeurs est le suivant", ((string)(null)), table2, "And ");
#line hidden
#line 30
 testRunner.When("le scrutin est clôturé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.Then("il y a un vainqueur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.And("\"candidat 1\" est désigné comme vainqueur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote",
                            "pourcentage"});
                table3.AddRow(new string[] {
                            "candidat 1",
                            "1",
                            "100"});
                table3.AddRow(new string[] {
                            "candidat 2",
                            "0",
                            "0"});
#line 33
 testRunner.And("le résultat du scrutin est le suivant", ((string)(null)), table3, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Scrutin majoritaire deux électeurs, pas de vainqueur au premier tour et vainqueur" +
            " au second tour", SourceLine=37)]
        public virtual void ScrutinMajoritaireDeuxElecteursPasDeVainqueurAuPremierTourEtVainqueurAuSecondTour()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scrutin majoritaire deux électeurs, pas de vainqueur au premier tour et vainqueur" +
                    " au second tour", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "DateDeNaissance"});
                table4.AddRow(new string[] {
                            "candidat 1",
                            "Jan 1, 1999"});
                table4.AddRow(new string[] {
                            "candidat 2",
                            "Jun 15, 1995"});
                table4.AddRow(new string[] {
                            "candidat 3",
                            "Jan 2, 1999"});
#line 39
 testRunner.Given("les candidats suivants", ((string)(null)), table4, "Given ");
#line hidden
#line 44
 testRunner.And("le tour de scrutin est ouvert", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote"});
                table5.AddRow(new string[] {
                            "candidat 1",
                            "4"});
                table5.AddRow(new string[] {
                            "candidat 2",
                            "2"});
                table5.AddRow(new string[] {
                            "candidat 3",
                            "3"});
#line 45
 testRunner.And("le vote des electeurs est le suivant", ((string)(null)), table5, "And ");
#line hidden
#line 50
 testRunner.When("le scrutin est clôturé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.Then("il n\'y a pas de vainqueur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote",
                            "pourcentage"});
                table6.AddRow(new string[] {
                            "candidat 1",
                            "4",
                            "44.44"});
                table6.AddRow(new string[] {
                            "candidat 2",
                            "2",
                            "22.22"});
                table6.AddRow(new string[] {
                            "candidat 3",
                            "3",
                            "33.33"});
#line 52
 testRunner.And("le résultat du scrutin est le suivant", ((string)(null)), table6, "And ");
#line hidden
#line 57
 testRunner.And("un autre tour de scrutin est possible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom"});
                table7.AddRow(new string[] {
                            "candidat 1"});
                table7.AddRow(new string[] {
                            "candidat 3"});
#line 58
 testRunner.And("les candidats suivants sont qualifiés", ((string)(null)), table7, "And ");
#line hidden
#line 62
 testRunner.Given("le tour de scrutin est ouvert", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote"});
                table8.AddRow(new string[] {
                            "candidat 1",
                            "1"});
                table8.AddRow(new string[] {
                            "candidat 3",
                            "3"});
#line 63
 testRunner.And("le vote des electeurs est le suivant", ((string)(null)), table8, "And ");
#line hidden
#line 67
 testRunner.When("le scrutin est clôturé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.Then("il y a un vainqueur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.And("\"candidat 3\" est désigné comme vainqueur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote",
                            "pourcentage"});
                table9.AddRow(new string[] {
                            "candidat 1",
                            "1",
                            "25"});
                table9.AddRow(new string[] {
                            "candidat 3",
                            "3",
                            "75"});
#line 70
 testRunner.And("le résultat du scrutin est le suivant", ((string)(null)), table9, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Scrutin majoritaire deux électeurs, pas de vainqueur au premier tour et pas de va" +
            "inqueur au second tour", SourceLine=74)]
        public virtual void ScrutinMajoritaireDeuxElecteursPasDeVainqueurAuPremierTourEtPasDeVainqueurAuSecondTour()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scrutin majoritaire deux électeurs, pas de vainqueur au premier tour et pas de va" +
                    "inqueur au second tour", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 75
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "DateDeNaissance"});
                table10.AddRow(new string[] {
                            "candidat 1",
                            "Jan 1, 1999"});
                table10.AddRow(new string[] {
                            "candidat 2",
                            "Jun 15, 1995"});
                table10.AddRow(new string[] {
                            "candidat 3",
                            "Jan 2, 1999"});
#line 76
 testRunner.Given("les candidats suivants", ((string)(null)), table10, "Given ");
#line hidden
#line 81
 testRunner.And("le tour de scrutin est ouvert", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote"});
                table11.AddRow(new string[] {
                            "candidat 1",
                            "1"});
                table11.AddRow(new string[] {
                            "candidat 3",
                            "1"});
#line 82
 testRunner.And("le vote des electeurs est le suivant", ((string)(null)), table11, "And ");
#line hidden
#line 86
 testRunner.When("le scrutin est clôturé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then("il n\'y a pas de vainqueur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote",
                            "pourcentage"});
                table12.AddRow(new string[] {
                            "candidat 1",
                            "1",
                            "50"});
                table12.AddRow(new string[] {
                            "candidat 2",
                            "0",
                            "0"});
                table12.AddRow(new string[] {
                            "candidat 3",
                            "1",
                            "50"});
#line 88
 testRunner.And("le résultat du scrutin est le suivant", ((string)(null)), table12, "And ");
#line hidden
#line 93
 testRunner.And("un autre tour de scrutin est possible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom"});
                table13.AddRow(new string[] {
                            "candidat 1"});
                table13.AddRow(new string[] {
                            "candidat 3"});
#line 94
 testRunner.And("les candidats suivants sont qualifiés", ((string)(null)), table13, "And ");
#line hidden
#line 98
 testRunner.Given("le tour de scrutin est ouvert", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote"});
                table14.AddRow(new string[] {
                            "candidat 1",
                            "1"});
                table14.AddRow(new string[] {
                            "candidat 3",
                            "1"});
#line 99
 testRunner.And("le vote des electeurs est le suivant", ((string)(null)), table14, "And ");
#line hidden
#line 103
 testRunner.When("le scrutin est clôturé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote",
                            "pourcentage"});
                table15.AddRow(new string[] {
                            "candidat 1",
                            "1",
                            "50"});
                table15.AddRow(new string[] {
                            "candidat 3",
                            "1",
                            "50"});
#line 104
 testRunner.Then("le résultat du scrutin est le suivant", ((string)(null)), table15, "Then ");
#line hidden
#line 108
 testRunner.And("il n\'y a pas de vainqueur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.And("un autre tour de scrutin n\'est pas possible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Scrutin majoritaire deux électeurs, pas de vainqueur au premier tour et égalité s" +
            "ur les 2eme et 3eme candidat", SourceLine=115)]
        public virtual void ScrutinMajoritaireDeuxElecteursPasDeVainqueurAuPremierTourEtEgaliteSurLes2EmeEt3EmeCandidat()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scrutin majoritaire deux électeurs, pas de vainqueur au premier tour et égalité s" +
                    "ur les 2eme et 3eme candidat", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 116
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "DateDeNaissance"});
                table16.AddRow(new string[] {
                            "candidat 1",
                            "Jan 1, 1999"});
                table16.AddRow(new string[] {
                            "candidat 2",
                            "Jun 15, 1995"});
                table16.AddRow(new string[] {
                            "candidat 3",
                            "Jan 2, 1999"});
#line 117
 testRunner.Given("les candidats suivants", ((string)(null)), table16, "Given ");
#line hidden
#line 122
 testRunner.And("le tour de scrutin est ouvert", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote"});
                table17.AddRow(new string[] {
                            "candidat 1",
                            "2"});
                table17.AddRow(new string[] {
                            "candidat 2",
                            "3"});
                table17.AddRow(new string[] {
                            "candidat 3",
                            "2"});
#line 123
 testRunner.And("le vote des electeurs est le suivant", ((string)(null)), table17, "And ");
#line hidden
#line 128
 testRunner.When("le scrutin est clôturé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 129
 testRunner.Then("il n\'y a pas de vainqueur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote",
                            "pourcentage"});
                table18.AddRow(new string[] {
                            "candidat 1",
                            "2",
                            "28.57"});
                table18.AddRow(new string[] {
                            "candidat 2",
                            "3",
                            "42.86"});
                table18.AddRow(new string[] {
                            "candidat 3",
                            "2",
                            "28.57"});
#line 130
 testRunner.And("le résultat du scrutin est le suivant", ((string)(null)), table18, "And ");
#line hidden
#line 135
 testRunner.And("un autre tour de scrutin est possible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom"});
                table19.AddRow(new string[] {
                            "candidat 1"});
                table19.AddRow(new string[] {
                            "candidat 2"});
#line 136
 testRunner.And("les candidats suivants sont qualifiés", ((string)(null)), table19, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Scrutin majoritaire un électeur et un vainqueur, gestion des votes blancs ou nuls" +
            "", SourceLine=140)]
        public virtual void ScrutinMajoritaireUnElecteurEtUnVainqueurGestionDesVotesBlancsOuNuls()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scrutin majoritaire un électeur et un vainqueur, gestion des votes blancs ou nuls" +
                    "", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 141
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "DateDeNaissance"});
                table20.AddRow(new string[] {
                            "candidat 1",
                            "Jan 1, 1999"});
                table20.AddRow(new string[] {
                            "candidat 2",
                            "Jun 15, 1995"});
#line 142
 testRunner.Given("les candidats suivants", ((string)(null)), table20, "Given ");
#line hidden
#line 146
 testRunner.And("le tour de scrutin est ouvert", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote"});
                table21.AddRow(new string[] {
                            "candidat 1",
                            "1"});
                table21.AddRow(new string[] {
                            "",
                            "1"});
                table21.AddRow(new string[] {
                            "adcve",
                            "1"});
#line 147
 testRunner.And("le vote des electeurs est le suivant", ((string)(null)), table21, "And ");
#line hidden
#line 152
 testRunner.When("le scrutin est clôturé", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 153
 testRunner.Then("il y a un vainqueur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 154
 testRunner.And("\"candidat 1\" est désigné comme vainqueur", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "Nom",
                            "Nombre de vote",
                            "pourcentage"});
                table22.AddRow(new string[] {
                            "candidat 1",
                            "1",
                            "100"});
                table22.AddRow(new string[] {
                            "candidat 2",
                            "0",
                            "0"});
#line 155
 testRunner.And("le résultat du scrutin est le suivant", ((string)(null)), table22, "And ");
#line hidden
#line 159
 testRunner.And("il y a 2 votes blancs ou nuls", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion