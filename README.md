# Wiki.Net

[![License](https://img.shields.io/github/license/Creepysin-Studios/Wiki.Net)](/LICENSE) [![Discord](https://img.shields.io/badge/Discord-Creepysin-7289da.svg?logo=discord)](https://discord.creepysin.com)

Wiki.Net – An unofficial C# Wikipedia API

## Features

Searches Wikipedia (duh!) and returns:
* Page ID
* Titles
* Word Count
* Size (bytes?)
* Text Preview
* URL of page

## Example

```csharp
string searchString = “Computer”;

WikiSearchResponse response = WikiSearcher.Request(searchString);

foreach (WikiSearchResult result in response.Query.SearchResults)
{
	Console.WriteLine($"{result.Title} ({result.WordCount} words)\n{result.Preview}...\n{result.Url}\n");
}

Console.ReadLine();
```

**Output**
```
Computer (12154 words)
A computer is a machine that can be instructed to carry out sequences of arithmetic or logical operations automatically via computer programming. Modern...
https://en.wikipedia.org/?curid=7878457

Computer science (7267 words)
Computer science (sometimes called computation science or computing science, but not to be confused with computational science or software engineering)...
https://en.wikipedia.org/?curid=5323

*More results*
```

## Authors

**EternalClickbait** - *Initial work* - [EternalClickbait]( https://github.com/EternalClickbait)

## License

This project is licensed under the Mozilla Public License 2.0 – see the [LICENSE](/LICENSE) file for details.