function initScrollWatcher(dotNetHelper){

    const triggerHeight = document.getElementById("hero").offsetHeight;

    window.addEventListener("scroll", () => {
        const scrollY = window.scrollY || document.documentElement.scrollTop;
        dotNetHelper.invokeMethodAsync("SetNavBarVisibility", scrollY > triggerHeight);
    });
}