using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace DictionaryApp.Models
{
    public class Metadata
    {
        public string operation { get; set; }
        public string provider { get; set; }
        public string schema { get; set; }
    }

    public class Pronunciation
    {
        public string audioFile { get; set; }
        public IList<string> dialects { get; set; }
        public string phoneticNotation { get; set; }
        public string phoneticSpelling { get; set; }
    }

    public class DomainClass
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Register
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Note
    {
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Example
    {
        public string text { get; set; }
        public IList<Register> registers { get; set; }
        public IList<Note> notes { get; set; }
    }

    public class SemanticClass
    {
        public string id { get; set; }
        public string text { get; set; }
    }


    public class Domain
    {
        public string id { get; set; }
        public string text { get; set; }
    }


    public class Subsens
    {
        public IList<string> definitions { get; set; }
        public IList<DomainClass> domainClasses { get; set; }
        public IList<Example> examples { get; set; }
        public string id { get; set; }
        public IList<SemanticClass> semanticClasses { get; set; }
        public IList<string> shortDefinitions { get; set; }
        public IList<Domain> domains { get; set; }
        public IList<Register> registers { get; set; }
        public IList<Note> notes { get; set; }
    }

    public class Synonym
    {
        public string language { get; set; }
        public string text { get; set; }
    }

    public class ThesaurusLink
    {
        public string entry_id { get; set; }
        public string sense_id { get; set; }
    }

    public class Region
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Sens
    {
        public IList<string> definitions { get; set; }
        public IList<DomainClass> domainClasses { get; set; }
        public IList<Example> examples { get; set; }
        public string id { get; set; }
        public IList<SemanticClass> semanticClasses { get; set; }
        public IList<string> shortDefinitions { get; set; }
        public IList<Register> registers { get; set; }
        public IList<Subsens> subsenses { get; set; }
        public IList<Synonym> synonyms { get; set; }
        public IList<ThesaurusLink> thesaurusLinks { get; set; }
        public IList<Region> regions { get; set; }
    }

    public class GrammaticalFeature
    {
        public string id { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Entry
    {
        public IList<string> etymologies { get; set; }
        public string homographNumber { get; set; }
        public IList<Pronunciation> pronunciations { get; set; }
        public IList<Sens> senses { get; set; }
        public IList<GrammaticalFeature> grammaticalFeatures { get; set; }
    }

    public class LexicalCategory
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class Phras
    {
        public string id { get; set; }
        public string text { get; set; }
    }

    public class LexicalEntry
    {
        public IList<Entry> entries { get; set; }
        public string language { get; set; }
        public LexicalCategory lexicalCategory { get; set; }
        public IList<Phras> phrases { get; set; }
        public string text { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string language { get; set; }
        public IList<LexicalEntry> lexicalEntries { get; set; }
        public string type { get; set; }
        public string word { get; set; }
    }

    public class Word
    {
        public string id { get; set; }
        public Metadata metadata { get; set; }
        public IList<Result> results { get; set; }
        public string word { get; set; }
    }


}
