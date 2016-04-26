using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Extensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendFormattedLine(
            this StringBuilder @this,
            string format,
            params object[] args) =>
                @this.AppendFormat(format, args)
                    .AppendLine();

        public static StringBuilder AppendLineWhen(
            this StringBuilder @this,
            Func<bool> predicate,
            string value) =>
                predicate()
                    ? @this.AppendLine(value)
                    : @this;

        public static StringBuilder AppendSequence<T>(
            this StringBuilder @this,
            IEnumerable<T> seq,
            Func<StringBuilder, T, StringBuilder> func) =>
                seq.Aggregate(@this, func);

    }
}
