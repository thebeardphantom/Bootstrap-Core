using System;

namespace BeardPhantom.Bootstrap.Core
{
    public abstract class AppSession : IEquatable<AppSession>
    {
        public readonly Guid Guid = Guid.NewGuid();

        public virtual bool Equals(AppSession other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Guid.Equals(other.Guid);
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((AppSession)obj);
        }

        public override int GetHashCode()
        {
            return Guid.GetHashCode();
        }
    }
}