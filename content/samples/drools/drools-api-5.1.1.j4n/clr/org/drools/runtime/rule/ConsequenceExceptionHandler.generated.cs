//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.runtime.rule {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ConsequenceExceptionHandler {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/runtime/rule/Activation;Lorg/drools/runtime/rule/WorkingMemory;Ljava" +
            "/lang/Exception;)V")]
        void handleException(global::org.drools.runtime.rule.Activation par0, global::org.drools.runtime.rule.WorkingMemory par1, global::java.lang.Exception par2);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ConsequenceExceptionHandler_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.runtime.rule.@__ConsequenceExceptionHandler.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.runtime.rule.ConsequenceExceptionHandler), typeof(global::org.drools.runtime.rule.ConsequenceExceptionHandler_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.runtime.rule.ConsequenceExceptionHandler), typeof(global::org.drools.runtime.rule.ConsequenceExceptionHandler_))]
    internal sealed partial class @__ConsequenceExceptionHandler : global::java.lang.Object, global::org.drools.runtime.rule.ConsequenceExceptionHandler {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _handleException0;
        
        private @__ConsequenceExceptionHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.runtime.rule.@__ConsequenceExceptionHandler.staticClass = @__class;
            global::org.drools.runtime.rule.@__ConsequenceExceptionHandler._handleException0 = @__env.GetMethodID(global::org.drools.runtime.rule.@__ConsequenceExceptionHandler.staticClass, "handleException", "(Lorg/drools/runtime/rule/Activation;Lorg/drools/runtime/rule/WorkingMemory;Ljava" +
                    "/lang/Exception;)V");
        }
        
        public void handleException(global::org.drools.runtime.rule.Activation par0, global::org.drools.runtime.rule.WorkingMemory par1, global::java.lang.Exception par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.rule.@__ConsequenceExceptionHandler._handleException0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.rule.Activation>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.rule.WorkingMemory>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ConsequenceExceptionHandler);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "handleException", "handleException0", "(Lorg/drools/runtime/rule/Activation;Lorg/drools/runtime/rule/WorkingMemory;Ljava" +
                        "/lang/Exception;)V"));
            return methods;
        }
        
        private static void handleException0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1, global::net.sf.jni4net.utils.JniLocalHandle par2) {
            // (Lorg/drools/runtime/rule/Activation;Lorg/drools/runtime/rule/WorkingMemory;Ljava/lang/Exception;)V
            // (Lorg/drools/runtime/rule/Activation;Lorg/drools/runtime/rule/WorkingMemory;Ljava/lang/Exception;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.rule.ConsequenceExceptionHandler @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.ConsequenceExceptionHandler>(@__env, @__obj);
            @__real.handleException(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.Activation>(@__env, par0), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.WorkingMemory>(@__env, par1), global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Exception>(@__env, par2));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.runtime.rule.@__ConsequenceExceptionHandler(@__env);
            }
        }
    }
    #endregion
}
