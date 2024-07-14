class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(NumUniqueEmails(new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" }));
    }
    public static int NumUniqueEmails(string[] emails)
    {
        HashSet<string> set = new HashSet<string>();
        for(int i = 0; i<emails.Length; i++)
        {
            var email = emails[i].Split('@');
            var localName= email[0];
            var domainName= email[1];
            if (localName.Contains('+'))
                localName=localName.Split('+')[0];
            if (localName.Contains('.')) localName=localName.Replace(".", string.Empty);
            if(!set.Contains(localName+"@"+domainName)) set.Add(localName+"@"+domainName);
        }
        return set.Count;
    }
}