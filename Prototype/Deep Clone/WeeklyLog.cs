using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Clone1
{
    [Serializable]
    class WeeklyLog : ICloneable
    {
        private Attachment attachment;
        private string name;
        private string date;
        private string content;

        public Attachment Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        //使用序列化方式实现深克隆
        //public Object Clone()
        //{
        //    Object clone = null;
        //    FileStream fs = new FileStream("Temp.dat", FileMode.Create);
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    try
        //    {
        //        formatter.Serialize(fs, this);
        //    }
        //    catch (SerializationException e)
        //    {
        //        Console.WriteLine("Failed to serialize. Reason: " + e.Message);
        //        throw;
        //    }
        //    finally
        //    {
        //        fs.Close();
        //    }

        //    FileStream fs1 = new FileStream("Temp.dat", FileMode.Open);
        //    BinaryFormatter formatter1 = new BinaryFormatter();
        //    try
        //    {
        //        clone = (WeeklyLog)formatter1.Deserialize(fs1);
        //    }
        //    catch (SerializationException e)
        //    {
        //        Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
        //        throw;
        //    }
        //    finally
        //    {
        //        fs.Close();
        //    }
        //    return clone;
        //}

            //public Object Clone()
        /// <summary>
        /// 反射方式进行Clone
        /// </summary>
        /// <returns>新对象</returns>
        public Object Copy(object obj)
        {
            if (obj == null)
            {
                return null;
            }
            Object targetDeepCopyObj;
            Type targetType = obj.GetType();
            //值类型  
            if (targetType.IsValueType == true)
            {
                targetDeepCopyObj = obj;
            }
            //引用类型   
            else
            {
                targetDeepCopyObj = System.Activator.CreateInstance(targetType);   //创建引用对象   
                System.Reflection.MemberInfo[] memberCollection = obj.GetType().GetMembers();

                foreach (System.Reflection.MemberInfo member in memberCollection)
                {
                    //拷贝字段
                    if (member.MemberType == System.Reflection.MemberTypes.Field)
                    {
                        System.Reflection.FieldInfo field = (System.Reflection.FieldInfo)member;
                        Object fieldValue = field.GetValue(obj);
                        if (fieldValue is ICloneable)
                        {
                            field.SetValue(targetDeepCopyObj, (fieldValue as ICloneable).Clone());
                        }
                        else
                        {
                            field.SetValue(targetDeepCopyObj, Copy(fieldValue));
                        }

                    }
                    //拷贝属性
                    else if (member.MemberType == System.Reflection.MemberTypes.Property)
                    {
                        System.Reflection.PropertyInfo myProperty = (System.Reflection.PropertyInfo)member;

                        MethodInfo info = myProperty.GetSetMethod(false);
                        if (info != null)
                        {
                            try
                            {
                                object propertyValue = myProperty.GetValue(obj, null);
                                if (propertyValue is ICloneable)
                                {
                                    myProperty.SetValue(targetDeepCopyObj, (propertyValue as ICloneable).Clone(), null);
                                }
                                else
                                {
                                    myProperty.SetValue(targetDeepCopyObj, Copy(propertyValue), null);
                                }
                            }
                            catch (System.Exception ex)
                            {

                            }
                        }
                    }
                }
            }
            return targetDeepCopyObj;
        }

        public object Clone()
        {
            Object obj = Copy(this);
            return obj;
        }
    }
}