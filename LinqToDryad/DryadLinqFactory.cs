/*
Copyright (c) Microsoft Corporation

All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in 
compliance with the License.  You may obtain a copy of the License 
at http://www.apache.org/licenses/LICENSE-2.0   


THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER 
EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF 
TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT.  


See the Apache Version 2.0 License for specific language governing permissions and 
limitations under the License. 

*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Data.SqlTypes;
using Microsoft.Research.DryadLinq;

namespace Microsoft.Research.DryadLinq.Internal
{
    public abstract class DryadLinqFactory<T>
    {
        public abstract DryadLinqRecordReader<T> MakeReader(NativeBlockStream nativeStream);
        public abstract DryadLinqRecordReader<T> MakeReader(IntPtr handle, UInt32 port);
        public abstract DryadLinqRecordWriter<T> MakeWriter(NativeBlockStream nativeStream);
        public abstract DryadLinqRecordWriter<T> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize);
    }

    public sealed class DryadLinqFactoryByte : DryadLinqFactory<byte>
    {
        public override DryadLinqRecordReader<byte> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordByteReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<byte> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordByteReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<byte> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordByteWriter(new DryadLinqBinaryWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<byte> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordByteWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactorySByte : DryadLinqFactory<sbyte>
    {
        public override DryadLinqRecordReader<sbyte> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordSByteReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<sbyte> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordSByteReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<sbyte> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordSByteWriter(new DryadLinqBinaryWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<sbyte> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordSByteWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactoryBool : DryadLinqFactory<bool>
    {
        public override DryadLinqRecordReader<bool> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordBoolReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<bool> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordBoolReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<bool> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordBoolWriter(new DryadLinqBinaryWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<bool> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordBoolWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }
    
    public sealed class DryadLinqFactoryChar : DryadLinqFactory<char>
    {
        public override DryadLinqRecordReader<char> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordCharReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<char> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordCharReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<char> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordCharWriter(new DryadLinqBinaryWriter(nativeStream));
        }
        
        public override DryadLinqRecordWriter<char> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordCharWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactoryShort : DryadLinqFactory<short>
    {
        public override DryadLinqRecordReader<short> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordShortReader(new DryadLinqBinaryReader(nativeStream));
        }
        
        public override DryadLinqRecordReader<short> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordShortReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<short> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordShortWriter(new DryadLinqBinaryWriter(nativeStream));
        }
        
        public override DryadLinqRecordWriter<short> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordShortWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactoryUShort : DryadLinqFactory<ushort>
    {
        public override DryadLinqRecordReader<ushort> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordUShortReader(new DryadLinqBinaryReader(nativeStream));
        }
        
        public override DryadLinqRecordReader<ushort> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordUShortReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<ushort> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordUShortWriter(new DryadLinqBinaryWriter(nativeStream));
        }
        
        public override DryadLinqRecordWriter<ushort> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordUShortWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactoryInt32 : DryadLinqFactory<int>
    {
        public override DryadLinqRecordReader<int> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordInt32Reader(new DryadLinqBinaryReader(nativeStream));
        }
        
        public override DryadLinqRecordReader<int> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordInt32Reader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<int> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordInt32Writer(new DryadLinqBinaryWriter(nativeStream));
        }
        
        public override DryadLinqRecordWriter<int> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordInt32Writer(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }
    
    public sealed class DryadLinqFactoryUInt32 : DryadLinqFactory<uint>
    {
        public override DryadLinqRecordReader<uint> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordUInt32Reader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<uint> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordUInt32Reader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<uint> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordUInt32Writer(new DryadLinqBinaryWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<uint> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordUInt32Writer(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }
    
    public sealed class DryadLinqFactoryInt64 : DryadLinqFactory<long>
    {
        public override DryadLinqRecordReader<long> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordInt64Reader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<long> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordInt64Reader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<long> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordInt64Writer(new DryadLinqBinaryWriter(nativeStream));
        }
        
        public override DryadLinqRecordWriter<long> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordInt64Writer(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }
    
    public sealed class DryadLinqFactoryUInt64 : DryadLinqFactory<ulong>
    {
        public override DryadLinqRecordReader<ulong> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordUInt64Reader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<ulong> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordUInt64Reader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<ulong> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordUInt64Writer(new DryadLinqBinaryWriter(nativeStream));
        }
        
        public override DryadLinqRecordWriter<ulong> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordUInt64Writer(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactoryFloat : DryadLinqFactory<float>
    {
        public override DryadLinqRecordReader<float> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordFloatReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<float> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordFloatReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<float> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordFloatWriter(new DryadLinqBinaryWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<float> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordFloatWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactoryDecimal : DryadLinqFactory<decimal>
    {
        public override DryadLinqRecordReader<decimal> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordDecimalReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<decimal> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordDecimalReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<decimal> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordDecimalWriter(new DryadLinqBinaryWriter(nativeStream));
        }
        
        public override DryadLinqRecordWriter<decimal> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordDecimalWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactoryDouble : DryadLinqFactory<double>
    {
        public override DryadLinqRecordReader<double> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordDoubleReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<double> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordDoubleReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<double> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordDoubleWriter(new DryadLinqBinaryWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<double> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordDoubleWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactoryDateTime : DryadLinqFactory<DateTime>
    {
        public override DryadLinqRecordReader<DateTime> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordDateTimeReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<DateTime> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordDateTimeReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<DateTime> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordDateTimeWriter(new DryadLinqBinaryWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<DateTime> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordDateTimeWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }
    
    public sealed class DryadLinqFactoryString : DryadLinqFactory<string>
    {
        public override DryadLinqRecordReader<string> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordStringReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<string> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordStringReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<string> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordStringWriter(new DryadLinqBinaryWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<string> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordStringWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactoryGuid : DryadLinqFactory<Guid>
    {
        public override DryadLinqRecordReader<Guid> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadRecordGuidReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<Guid> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadRecordGuidReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<Guid> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordGuidWriter(new DryadLinqBinaryWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<Guid> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordGuidWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactoryLineRecord : DryadLinqFactory<LineRecord>
    {
        public override DryadLinqRecordReader<LineRecord> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordTextReader(new DryadLinqTextReader(nativeStream));
        }

        public override DryadLinqRecordReader<LineRecord> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordTextReader(new DryadLinqTextReader(handle, port));
        }

        public override DryadLinqRecordWriter<LineRecord> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordTextWriter(new DryadLinqTextWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<LineRecord> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordTextWriter(new DryadLinqTextWriter(handle, port, buffSize));
        }
    }

    public sealed class DryadLinqFactorySqlDateTime : DryadLinqFactory<SqlDateTime>
    {
        public override DryadLinqRecordReader<SqlDateTime> MakeReader(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordSqlDateTimeReader(new DryadLinqBinaryReader(nativeStream));
        }

        public override DryadLinqRecordReader<SqlDateTime> MakeReader(IntPtr handle, UInt32 port)
        {
            return new DryadLinqRecordSqlDateTimeReader(new DryadLinqBinaryReader(handle, port));
        }

        public override DryadLinqRecordWriter<SqlDateTime> MakeWriter(NativeBlockStream nativeStream)
        {
            return new DryadLinqRecordSqlDateTimeWriter(new DryadLinqBinaryWriter(nativeStream));
        }

        public override DryadLinqRecordWriter<SqlDateTime> MakeWriter(IntPtr handle, UInt32 port, Int32 buffSize)
        {
            return new DryadLinqRecordSqlDateTimeWriter(new DryadLinqBinaryWriter(handle, port, buffSize));
        }
    }
}
