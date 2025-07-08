function toggleSidebar() {
    const main = document.querySelector('.body-container');
    if (main) {
        main.classList.toggle('hide-sd');
    }

    const sidebar = document.getElementById('sidebar-desk');
    if (sidebar) {
        sidebar.classList.toggle('tbk-sidebar-hide');
    }
}

function collapseSidebar(element) {
    const content = element.nextElementSibling;
    const arrow = element.querySelector('.arrow');
    content.classList.toggle('open');
    arrow.classList.toggle('sidebar-icons-rotate');
}

function highlightByCurrentPath(currentPath) {
    document.querySelectorAll("li.collapsible-items > a").forEach((anchor) => {
        const linkPath = anchor.getAttribute("href") || "";
        if (currentPath === linkPath) {
            const liItem = anchor.parentElement;
            liItem.classList.add("active");

            const collapsibleUl = liItem.closest(".collapsible-content");
            if (collapsibleUl) {
                collapsibleUl.classList.add("open");

                const collapsibleButton = collapsibleUl.previousElementSibling;
                if (collapsibleButton) {
                    const icon = collapsibleButton.querySelector("img");
                    if (icon) icon.classList.add("sidebar-icons-rotate");
                }
            }
        }
    });
}

function highlightPrincipalPath(principalPath) {
    document.querySelectorAll("li.collapsible-items > a").forEach((anchor) => {
        const linkPath = anchor.getAttribute("href") || "";
        const principalLinkPath = linkPath.split("/")[1];
        const activeCurrentAnchor = principalLinkPath === principalPath

        if (activeCurrentAnchor) {
            const liItem = anchor.parentElement;
            liItem.classList.add("active");

            const collapsibleUl = liItem.closest(".collapsible-content");
            if (collapsibleUl) {
                collapsibleUl.classList.add("open");

                const collapsibleButton = collapsibleUl.previousElementSibling;
                if (collapsibleButton) {
                    const icon = collapsibleButton.querySelector("img");
                    if (icon) icon.classList.add("sidebar-icons-rotate");
                }
            }
        }
    });
}

function highlightActiveByUrl() {
    const currentPath = window.location.pathname;
    const principalPath = currentPath.split("/")[1];

    if (currentPath.startsWith('/api-reference')) {
        highlightByCurrentPath(currentPath)
    } else {
        highlightPrincipalPath(principalPath)
    }
};