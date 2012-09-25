// Module script for production
import kotlin.modules.*
fun project() {
    module("journey") {
        sources += "/Users/hadi/Dropbox/Blog/kotlin/journey/src/functions.kt"
        // Boot classpath
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/lib/ant-javafx.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/lib/dt.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/lib/javafx-doclet.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/lib/javafx-mx.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/lib/jconsole.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/lib/sa-jdi.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/lib/tools.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/charsets.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/jce.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/jfr.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/jfxrt.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/JObjC.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/jsse.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/management-agent.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/resources.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/rt.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/ext/dnsns.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/ext/localedata.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/ext/sunec.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/ext/sunjce_provider.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/ext/sunpkcs11.jar"
        classpath += "/Library/Java/JavaVirtualMachines/1.7.0.jdk/Contents/Home/jre/lib/ext/zipfs.jar"
        // Compilation classpath
        // Output directory, commented out
        //         classpath += "/Users/hadi/Dropbox/Blog/kotlin/journey/out/test/journey"
        // Output directory, commented out
        //         classpath += "/Users/hadi/Dropbox/Blog/kotlin/journey/out/production/journey"
        classpath += "/Users/hadi/Dropbox/Blog/kotlin/journey/lib/kotlin-runtime.jar"
        classpath += "/Applications/Leda-IU-122.327.app/lib/junit-4.10.jar"
        // Java classpath (for Java sources)
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_Maven_Resources_Compiler/journey.23054cdc/production"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/ActionScript_Compiler/journey.23054cdc/production"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_Maven_Resources_Compiler/journey.23054cdc/test"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/ActionScript_Compiler/journey.23054cdc/test"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Flex_Resource_Compiler/journey.23054cdc/production"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_External_Apklib_Extracting_Compiler/journey.23054cdc/production"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Flex_Resource_Compiler/journey.23054cdc/test"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_External_Apklib_Extracting_Compiler/journey.23054cdc/test"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_Renderscript_Compiler/journey.23054cdc/production"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_Renderscript_Compiler/journey.23054cdc/test"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_Including_Compiler/journey.23054cdc/production"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_Including_Compiler/journey.23054cdc/test"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/aapt/journey.23054cdc/test"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/aapt/journey.23054cdc/production"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_BuildConfig_Generator/journey.23054cdc/test"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_BuildConfig_Generator/journey.23054cdc/production"
        classpath += "/Users/hadi/Dropbox/Blog/kotlin/journey/test"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_PNG_files_caching_compiler/journey.23054cdc/test"
        classpath += "/Users/hadi/Dropbox/Blog/kotlin/journey/src"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/Android_PNG_files_caching_compiler/journey.23054cdc/production"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/aidl/journey.23054cdc/test"
        classpath += "/Users/hadi/Library/Caches/IntelliJIdea12/compiler/journey.aae71151/.generated/aidl/journey.23054cdc/production"
        // Main output
        // External annotations
        annotationsPath += "/Users/hadi/Library/Application Support/IntelliJIdea12/Kotlin/kotlinc/lib/kotlin-jdk-annotations.jar"
    }
}
