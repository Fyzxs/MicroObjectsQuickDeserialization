using System.Linq;

namespace FluentTypes.Texts
{
    internal sealed class FormatText : Text
    {
        private readonly Text _origin;
        private readonly Text[] _args;

        public FormatText(Text origin, params Text[] args)
        {
            _origin = origin;
            _args = args;
        }

        protected override string Value() => string.Format(_origin, RebaseArgs());

        // TODO: Should there be a TextCollection object to replace the Text[]?
        private string[] RebaseArgs() => _args.Select(o => (string)o).ToArray();
    }
}