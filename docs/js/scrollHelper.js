window.skillsScroller = {
    setScrollVars: (wrapperSelector, trackSelector) => {
        const wrapper = document.querySelector(wrapperSelector);
        const track = wrapper.querySelector(trackSelector);

        // The total track width is two copies of the skills list
        // so half the width = one copy
        const scrollDistance = track.scrollWidth / 2;

        // Adjust speed based on distance — 100px/sec here
        const scrollTime = scrollDistance / 100;

        wrapper.style.setProperty('--scroll-distance', `${scrollDistance}px`);
        wrapper.style.setProperty('--scroll-time', `${scrollTime}s`);
    }
};
