namespace Samples.HelloWorldTypeProvider

module public MyModule=
     let public Print x=for i in [0..x] do
                        printfn "%d" i

