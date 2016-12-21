# StronglyTypedConfiguration
A set of extension methods to make reading app.config or web.config settings using ConfigurationManager easier to use and to read.


Over the years doing code reviews I have seen a lot of abuse of configuration values and how they are used in code. Recently after
a particularly rough code review where a developer had peppered settings through business logic code using things like int.Parse
with no checking for validity of the value, using sensible defaults if settings were missing, or catching exceptions, I decided to
see if I could write something that would make meeting my standard a bit easier.

I prefer to have all settings stored in a settings class. This gives me a single place to go look to find all the "magic strings"
that relate to settings in config files. This is one place that has to be modified should keys change, new settings added, etc.
I also strongly prefer the use of TryParse and default values for missing settings.

What I came up with initially were two extension methods on NameValueCollection which is what AppSettings is in ConfigurationManager.
These extension methods initially just retrieved a single value or an array of values, casted them to the desired type, and allowed a
default value to be specified. This was a cool proof of concept that had to be tweaked when I wrote my unit tests and saw Guids were
not converting correctly. The logic now works with all the basic types - check out the Tests project!

After I made those methods I started thinking about how neat it is that WebAPI can bind a JSON object to a POCO as long as the
property names match. Why not for settings too? I wrote the third extension method to allow a serialized JSON object stored in
the configuration settings to be deserialized to a specific object. I was surprised when it worked the first time.

The code here is demonstration only and matches my preferences. Some people would suggest not swallowing exceptions while returning
explicit or implicit default values so the calling code has a chance to handle missing settings and that's cool. I prefer not to
take the expensive hit of throwing and catching exceptions when I know settings could be missing - it's not exceptional. I use
settings and default values to specify reasonable values that would normally be hardcoded that can be overridden by adding to the
configuration file. A missing setting is not exceptional but rather the rule. That's why I chose to allow default options to be
specified and as much as possible avoid exceptions and return type-defaults where necessary to reduce exception propagation.

I hope this reference code comes in handy to some people who might still be using ConfigurationManager.AppSettings or at least
serve as a model for reducing complexity in business logic. Note that this is not meant for .NET Core which already has the
ability to deserialize appSetings.json to concrete settings objects by default. It's a big time saver and easier to use since
settings can be written in JSON and not string-escaped for an app.config or web.config file; it's much more readable.
