window.highlightAllCodeBlocks = () => {
    if (window.hljs) {
        document.querySelectorAll('pre code').forEach(block => {
            hljs.highlightElement(block);
        });
    }
};
