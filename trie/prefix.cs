public class Solution {
    public int PrefixCount(string[] words, string pref) {
        Trie trie = new Trie();
        foreach(string word in words){
            trie.Insert(word);
        }
        return trie.CountWordsWithPrefix(pref);
    }
}

public class TrieNode {
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public int WordCount = 0;
}

public class Trie {
    private TrieNode root;

    public Trie(){
        root = new TrieNode();
    }

    public void Insert(string word){
        TrieNode cur = root;
        foreach(char ch in word){
            if(!cur.Children.ContainsKey(ch)) {
                cur.Children[ch] = new TrieNode();
            }
            cur = cur.Children[ch];
        }
        cur.WordCount++;
    }

    public int CountWordsWithPrefix(string prefix){
        // reach the node pointed to by prefix
        TrieNode cur = root;
        foreach(char ch in prefix){
            if(!cur.Children.ContainsKey(ch)) return 0;
            cur = cur.Children[ch];
        }

        // Sum wordCount of all child nodes
        return CountWords(cur);
    }

    private int CountWords(TrieNode node){
        int count = node.WordCount;
        foreach(var child in node.Children.Values){
            count += CountWords(child);
        }
        return count;
    }
}