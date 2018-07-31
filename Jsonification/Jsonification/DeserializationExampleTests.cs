using FluentTypes.Bools;
using FluentTypes.Texts;
using FluentTypes.Time;
using MicroObjectsLib.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;


/*
 * This is a quick hack job to answer a question on twitter...
 */
namespace Jsonification
{
    [TestClass]
    public class DeserializationExampleTests
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            Text json = new TextOf(@"{
    ""name"":""Quinn Fyzxs"",
    ""birthday"":""19061209""
    ""contact_info"":[
        {
            ""type"":""phone"",
            ""value"":""5551234567""
        }
    ]
}");
            IUser user = new User(json);

            Bool isMinor = (await user.Age()).IsMinor();
        }
    }

    /*
     * This is my "Domain Object". It represents the contents of the payload.
     * If I had multiple parts to the payload (users, orders) I'd build
     * some form of a "UserOrdersResponse" object that understands the payload
     * at the high level and will construct the additional objects I need.
     *
     * The User object becomes a 'knowledge' object. It doesn't have what I
     * typically call 'behavior'. It knows a thing instead of doing a thing.
     * It knows where the data is. It then provides that data to a new object.
     */
    public sealed class User : IUser
    {
        private static readonly Text BirthdayKey = new TextOf("birthday");
        private static readonly Text NameKey = new TextOf("name");

        private readonly IJsonObjectBookEnd _source;

        public User(Text json) : this(new JsonObjectBookEnd(json)) { }

        private User(IJsonObjectBookEnd source) => _source = source;

        public async Task<IAge> Age() => new Age(await _source.TextValue(BirthdayKey));
        public async Task<IName> Name() => new Name(await _source.TextValue(NameKey));
    }

    //Example class
    public sealed class Name : IName
    {
        private readonly Text _origin;

        public Name(Text origin) => _origin = origin;
    }

    public interface IName { }

    public interface IAge
    {
        Bool IsMinor();
    }

    /*
     * This is an example of another 'knowledge' class for a piece of information.
     * Typically it won't return hard coded values, but new objects with the birthday
     * provided to them.
     * A "new AmericanMinor(_birthday)", or a "new NewZealandCanByBooze(_birthday)"
     * to represent these behaviors. These classes then know how to check to interact
     * with the raw data to actually provide the answer.
     */
    public sealed class Age : IAge
    {
        private readonly TimeInstant _birthday;

        public Age(Text birthday) : this(new YearMonthDayTimeInstant(birthday)) { }

        private Age(TimeInstant birthday) => _birthday = birthday;

        public Bool IsMinor() => Bool.False;
        public Bool CanVote => Bool.True;
        public Bool CanBuyBooze() => Bool.False;

    }

    public interface IUser
    {
        Task<IAge> Age();
    }

    //Example of another knowledge class - this knows how to parse the YearMonthDay format of a date.
    public sealed class YearMonthDayTimeInstant : TimeInstant
    {
        private readonly Text _origin;

        public YearMonthDayTimeInstant(Text origin) => _origin = origin;

        protected override DateTime Value() => DateTime.Parse(_origin);
    }
}
