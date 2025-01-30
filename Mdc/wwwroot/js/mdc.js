window.behnammby = {};
window.behnammby.mdc = {};

window.behnammby.mdc.list = {
    init: function (element, objectRef) {
        if (element == null) {
            console.log("element is null!");
            return;
        }

        let mdcList = mdc.list.MDCList.attachTo(element);
        element.MDCList = mdcList;
    }
}

window.behnammby.mdc.drawer = {
    init: function (element, objectRef) {
        console.log("Initing drawer");
        console.log(element);

        if (element == null) {
            console.log("element is null!");
            return;
        }

        let mdcDrawer = mdc.drawer.MDCDrawer.attachTo(element);
        element.MDCDrawer = mdcDrawer;
    },
    test: function () {
        console.log("JSInterop!");
    }
}