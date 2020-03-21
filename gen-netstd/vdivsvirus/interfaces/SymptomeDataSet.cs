/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


namespace vdivsvirus.interfaces
{

  /// <summary>
  /// Structs of SymptomeDataSet [INPUT]
  /// </summary>
  public partial class SymptomeDataSet : TBase
  {
    private string _userID;
    private long _time;
    private Dictionary<string, SymptomeStrength> _symptomes;

    public string UserID
    {
      get
      {
        return _userID;
      }
      set
      {
        __isset.userID = true;
        this._userID = value;
      }
    }

    public long Time
    {
      get
      {
        return _time;
      }
      set
      {
        __isset.time = true;
        this._time = value;
      }
    }

    public Dictionary<string, SymptomeStrength> Symptomes
    {
      get
      {
        return _symptomes;
      }
      set
      {
        __isset.symptomes = true;
        this._symptomes = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool userID;
      public bool time;
      public bool symptomes;
    }

    public SymptomeDataSet()
    {
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                UserID = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                Time = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Map)
              {
                {
                  TMap _map8 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Symptomes = new Dictionary<string, SymptomeStrength>(_map8.Count);
                  for(int _i9 = 0; _i9 < _map8.Count; ++_i9)
                  {
                    string _key10;
                    SymptomeStrength _val11;
                    _key10 = await iprot.ReadStringAsync(cancellationToken);
                    _val11 = (SymptomeStrength)await iprot.ReadI32Async(cancellationToken);
                    Symptomes[_key10] = _val11;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("SymptomeDataSet");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (UserID != null && __isset.userID)
        {
          field.Name = "userID";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(UserID, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.time)
        {
          field.Name = "time";
          field.Type = TType.I64;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Time, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Symptomes != null && __isset.symptomes)
        {
          field.Name = "symptomes";
          field.Type = TType.Map;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.I32, Symptomes.Count), cancellationToken);
            foreach (string _iter12 in Symptomes.Keys)
            {
              await oprot.WriteStringAsync(_iter12, cancellationToken);
              await oprot.WriteI32Async((int)Symptomes[_iter12], cancellationToken);
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as SymptomeDataSet;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.userID == other.__isset.userID) && ((!__isset.userID) || (System.Object.Equals(UserID, other.UserID))))
        && ((__isset.time == other.__isset.time) && ((!__isset.time) || (System.Object.Equals(Time, other.Time))))
        && ((__isset.symptomes == other.__isset.symptomes) && ((!__isset.symptomes) || (TCollections.Equals(Symptomes, other.Symptomes))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.userID)
          hashcode = (hashcode * 397) + UserID.GetHashCode();
        if(__isset.time)
          hashcode = (hashcode * 397) + Time.GetHashCode();
        if(__isset.symptomes)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Symptomes);
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("SymptomeDataSet(");
      bool __first = true;
      if (UserID != null && __isset.userID)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("UserID: ");
        sb.Append(UserID);
      }
      if (__isset.time)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Time: ");
        sb.Append(Time);
      }
      if (Symptomes != null && __isset.symptomes)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Symptomes: ");
        sb.Append(Symptomes);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
