using System.Collections.Generic;
using System.Linq;

public static class Proverb
{
    public static string[] Recite(string[] subjects) => ReciteStream(subjects).ToArray();

    private static IEnumerable<string> ReciteStream(IEnumerable<string> subjects)
    {
        var firstSubject = "";
        while (subjects.Any())
        {
            if (firstSubject == "")
            {
                firstSubject = subjects.First();
            }

            var currentSubjects = subjects.Take(2).ToArray();
            switch (currentSubjects.Count())
            {
                case 2:
                    yield return $"For want of a {currentSubjects.First()} the {currentSubjects.Last()} was lost.";
                    break;
                case 1:
                    yield return $"And all for the want of a {firstSubject}.";
                    break;
                case 0:
                    yield break;
            }

            subjects = subjects.Skip(1);
        }
    }
}