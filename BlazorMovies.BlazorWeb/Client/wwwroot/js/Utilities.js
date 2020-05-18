function my_function(message) {
    console.log("from utilities " + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.BlazorWeb.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript " + result);
        });
}